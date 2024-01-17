using BicycleApp.Common.Providers.Contracts;
using BicycleApp.Data;
using BicycleApp.Services.Contracts;
using BicycleApp.Services.Models;
using BicycleApp.Services.Models.Supply;
using Microsoft.EntityFrameworkCore;

namespace BicycleApp.Services.Services
{
    public class SupplyManagerService : ISupplyManagerService
    {

        private readonly BicycleAppDbContext _dbContext;
        private readonly IModelsFactory _modelsFactory;
        private readonly IDateTimeProvider _dateTimeProvider;

        public SupplyManagerService(BicycleAppDbContext dbContext,
                                     IModelsFactory modelsFactory,
                                     IDateTimeProvider dateTimeProvider)
        {
            _dbContext = dbContext;
            _modelsFactory = modelsFactory;
            _dateTimeProvider = dateTimeProvider;
        }

        /// <summary>
        /// Gets all avaiable deliveries in database
        /// </summary>
        /// <returns>Dto's collection of all avaiable deliveries in database</returns>
        public async Task<DeliveryQueryDto> AllDeliveries(int currentPage)
        {
            if (currentPage <= 0)
            {
                throw new ArgumentNullException(nameof(currentPage));
            }

            int deliveriesPerPage = 6;

            var result = new DeliveryQueryDto();

            result.Deliveries = await _dbContext.Delivaries.AsQueryable()
                .AsNoTracking()
                .Skip((currentPage - 1) * deliveriesPerPage)
                .Take(deliveriesPerPage)
                .Select(d => new DeliveryDetailsDto
                {
                    Id = d.Id,
                    PartId = d.PartId,
                    QuantityDelivered = d.QuantityDelivered,
                    DateDelivered = d.DateDelivered,
                    SuplierId = d.SuplierId,
                    Note = d.Note,
                    SupplierName = d.Suplier.Name,
                    PartName = d.Part.Name,
                })
                .ToListAsync();

            result.TotalDeliveriesCount = await _dbContext.Delivaries.CountAsync();


            return result;
        }

        /// <summary>
        /// Gets all avaiable suppliers in database
        /// </summary>
        /// <returns>Dto's collection of all avaiable suppliers in database</returns>
        public async Task<ICollection<SuplierInfoDto>> AllSupliers()
        {
            try
            {
                var result = await _dbContext.Supliers
                .AsNoTracking()
                .Select(s => new SuplierInfoDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    ContactName = s.ContactName,
                    CategoryName = s.CategoryName,
                    Email = s.Email,
                    PhoneNumeber = s.PhoneNumeber,
                })
                .ToListAsync();

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("Database can't retrive data", ex);
            }
        }

        /// <summary>
        /// Gets all avaiable partOrders in database
        /// </summary>
        /// <returns>Dto's collection of all avaiable partOrders in database</returns>
        public async Task<ICollection<PartOrderInfoDto>> AllPartOrders()
        {
            try
            {
                var result = await _dbContext.PartOrders
                .AsNoTracking()
                .Select(po => new PartOrderInfoDto
                {
                    Id = po.Id,
                    PartName = po.Part.Name,
                    SuplierName = po.Suplier.Name,
                    Quantity = po.Quantity,
                })
                .ToListAsync();

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("Database can't retrive data", ex);
            }
        }

        /// <summary>
        /// Creates delivery record and update delivered part quantity in Db
        /// </summary>
        /// <param name="createDelivedryDto"></param>
        /// <returns>bool</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="Exception"></exception>
        public async Task<bool> CreateDelivedry(CreateDelivedryDto createDelivedryDto)
        {
            if (createDelivedryDto == null)
            {
                return false;
            }

            try
            {
                var delivery = _modelsFactory.CreateNewDelivery(createDelivedryDto);

                await _dbContext.Delivaries.AddAsync(delivery);

                var deliveredPart = await _dbContext.Parts.Where(p => p.Id == createDelivedryDto.PartId)
                    .FirstOrDefaultAsync();

                if (deliveredPart == null)
                {
                    throw new ArgumentNullException(nameof(createDelivedryDto.PartId));
                }

                //трябва да сетва в PartsInStock table SuplierId, PartId и OemPartNumber, САМО ако не съществува такъв запис!?
                deliveredPart.Quantity += createDelivedryDto.QuantityDelivered;

                await _dbContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Database can't save data", ex);
            }
        }

        /// <summary>
        /// Creates suplier make record in Db
        /// </summary>
        /// <param name="createDelivedryDto"></param>
        /// <returns>bool</returns>
        /// <exception cref="Exception"></exception>
        public async Task<bool> CreateSuplier(CreateSuplierDto createSuplierDto)
        {
            if (createSuplierDto == null)
            {
                return false;
            }

            try
            {
                var suplier = _modelsFactory.CreateNewSuplier(createSuplierDto);

                await _dbContext.Supliers.AddAsync(suplier);

                await _dbContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Database can't save data", ex);
            }
        }

        /// <summary>
        /// Create Part Order make record in Db
        /// </summary>
        /// <param name="createPartOrderryDto"></param>
        /// <returns>bool</returns>
        /// <exception cref="Exception"></exception>
        public async Task<bool> CreatePartOrder(CreatePartOrderDto createPartOrderryDto)
        {
            if (createPartOrderryDto == null)
            {
                return false;
            }

            try
            {
                var partOrder = _modelsFactory.CreateNewPartOrder(createPartOrderryDto);

                await _dbContext.AddAsync(partOrder);

                await _dbContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Database can't save data", ex);
            }
        }

        /// <summary>
        /// Manager set isDeleted proeprty to true and DateDeleted property is filled.
        /// </summary>
        /// <param name="deliveryId"></param>
        /// <returns>Task</returns>
        public async Task DeleteDeliveryById(int deliveryId)
        {
            if (deliveryId <= 0)
            {
                throw new ArgumentNullException(nameof(deliveryId));
            }

            try
            {
                var deliveryToReject = await _dbContext.Delivaries.FirstAsync(o => o.Id == deliveryId);
                deliveryToReject.DateDeleted = _dateTimeProvider.Now;
                deliveryToReject.IsDeleted = true;

                _dbContext.Delivaries.Update(deliveryToReject);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Database can't delete data", ex);
            };
        }

        /// <summary>
        /// Manager set isDeleted proeprty to true and DateDeleted property is filled.
        /// </summary>
        /// <param name="suplierId"></param>
        /// <returns>Task</returns>
        public async Task DeleteSuplierById(int suplierId)
        {

            if (suplierId <= 0)
            {
                throw new ArgumentNullException(nameof(suplierId));
            }

            try
            {
                var suplierToReject = await _dbContext.Supliers.FirstAsync(o => o.Id == suplierId);
                suplierToReject.DateDeleted = _dateTimeProvider.Now;
                suplierToReject.IsDeleted = true;

                _dbContext.Supliers.Update(suplierToReject);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Database can't delete data", ex);
            }
        }

        /// <summary>
        /// Manager set isDeleted proeprty to true and DateDeleted property is filled.
        /// </summary>
        /// <param name="partOrderId"></param>
        /// <returns>Task</returns>
        public async Task DeletePartOrderById(int partOrderId)
        {
            if (partOrderId <= 0)
            {
                throw new ArgumentNullException(nameof(partOrderId));
            }

            try
            {

                var partOrderToReject = await _dbContext.PartOrders.FirstAsync(po => po.Id == partOrderId);
                partOrderToReject.DateDeleted = _dateTimeProvider.Now;
                partOrderToReject.IsDeleted = true;

                _dbContext.PartOrders.Update(partOrderToReject);

                await _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Database can't delete data", ex);
            }
        }

        /// <summary>
        /// Returns DeliveryDetailsDto by deliveryId drom Db.
        /// </summary>
        /// <param name="deliveryId"></param>
        /// <returns>Task</returns>
        public async Task<DeliveryDetailsDto> DeliveryDetailsById(int deliveryId)
        {

            if (deliveryId <= 0)
            {
                throw new ArgumentNullException(nameof(deliveryId));
            }

            try
            {
                var result = await _dbContext.Delivaries
                .AsNoTracking()
                .Where(p => p.Id == deliveryId)
                .Select(p => new DeliveryDetailsDto
                {
                    Id = p.Id,
                    DateDelivered = p.DateDelivered,
                    PartId = p.PartId,
                    QuantityDelivered = p.QuantityDelivered,
                    Note = p.Note,
                    SuplierId = p.SuplierId,
                    SupplierName = p.Suplier.Name,
                    PartName = p.Part.Name,
                })
                .FirstAsync();

                return result;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Database can't retrive data", ex);
            }

        }

        /// <summary>
        /// Returns SuplierDetailsDto by suplierId from Db.
        /// </summary>
        /// <param name="suplierId"></param>
        /// <returns>Task</returns>
        public async Task<SuplierDetailsDto> SuplierDetailsById(int suplierId)
        {

            if (suplierId <= 0)
            {
                throw new ArgumentNullException(nameof(suplierId));
            }

            try
            {
                var result = await _dbContext.Supliers
                .AsNoTracking()
                .Where(p => p.Id == suplierId)
                .Select(p => new SuplierDetailsDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Address = p.Address,
                    VATNumber = p.VATNumber,
                    ContactName = p.ContactName,
                    Email = p.Email,
                    PhoneNumeber = p.PhoneNumeber,
                    CategoryName = p.CategoryName,
                })
                .FirstAsync();

                return result;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Database can't retrive data", ex);
            }
        }

        /// <summary>
        /// Returns PartOrderDetailsDto by partOrderId from Db.
        /// </summary>
        /// <param name="partOrderId"></param>
        /// <returns>Task</returns>
        public async Task<PartOrderDetailsDto> PartOrderDetailsById(int partOrderId)
        {
            if (partOrderId <= 0)
            {
                throw new ArgumentNullException(nameof(partOrderId));
            }

            try
            {
                var result = await _dbContext.PartOrders
                    .AsNoTracking()
                    .Where(po => po.Id == partOrderId)
                    .Select(po => new PartOrderDetailsDto
                    {
                        Id = po.Id,
                        PartName = po.Part.Name,
                        Note = po.Note,
                        Quantity = po.Quantity,
                        SuplierName = po.Suplier.Name,
                        DateCreated = po.DateCreated,
                    })
                    .FirstAsync();

                return result;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Database can't retrive data", ex);
            }
        }

        /// <summary>
        /// Update Delivery by Id in Db.
        /// </summary>
        /// <param name="editDelivedryDto"></param>
        /// <returns>bool</returns
        public async Task<bool> EditDeliveryById(EditDelivedryDto editDelivedryDto)
        {
            if (editDelivedryDto == null)
            {
                return false;
            }

            var delivery = await _dbContext.Delivaries
                .FirstOrDefaultAsync(d => d.Id == editDelivedryDto.Id);

            if (delivery == null)
            {
                return false;
            }

            delivery.PartId = editDelivedryDto.PartId == null ? delivery.PartId : editDelivedryDto.PartId;
            delivery.SuplierId = editDelivedryDto.SuplierId == null ? delivery.SuplierId : editDelivedryDto.SuplierId;
            delivery.DateDelivered = editDelivedryDto.DateDelivered == null ? delivery.DateDelivered : editDelivedryDto.DateDelivered;
            delivery.Note = editDelivedryDto.Note == null ? delivery.Note : editDelivedryDto.Note;
            delivery.QuantityDelivered = editDelivedryDto.QuantityDelivered == null ? delivery.QuantityDelivered : editDelivedryDto.QuantityDelivered;

            await _dbContext.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// Update Suplier by Id in Db.
        /// </summary>
        /// <param name="editSuplierDto"></param>
        /// <returns>bool</returns
        public async Task<bool> EditSuplierById(EditSuplierDto editSuplierDto)
        {
            if (editSuplierDto == null)
            {
                return false;
            }

            var suplier = await _dbContext.Supliers
                .FirstOrDefaultAsync(d => d.Id == editSuplierDto.Id);

            if (suplier == null)
            {
                return false;
            }

            suplier.Name = editSuplierDto.Name == null ? suplier.Name : editSuplierDto.Name;
            suplier.CategoryName = editSuplierDto.CategoryName == null ? suplier.CategoryName : editSuplierDto.CategoryName;
            suplier.ContactName = editSuplierDto.ContactName == null ? suplier.ContactName : editSuplierDto.ContactName;
            suplier.Address = editSuplierDto.Address == null ? suplier.Address : editSuplierDto.Address;
            suplier.Email = editSuplierDto.Email == null ? suplier.Email : editSuplierDto.Email;
            suplier.PhoneNumeber = editSuplierDto.PhoneNumeber == null ? suplier.PhoneNumeber : editSuplierDto.PhoneNumeber;

            await _dbContext.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// Update PartOrde by Id in Db.
        /// </summary>
        /// <param name="editePartOrderDto"></param>
        /// <returns>bool</returns
        public async Task<bool> EditPartOrderById(EditPartOrderDto editePartOrderDto)
        {
            if (editePartOrderDto == null)
            {
                return false;
            };

            var partOrder = await _dbContext.PartOrders
                .FirstOrDefaultAsync(po => po.Id == editePartOrderDto.Id);

            if (partOrder == null)
            {
                return false;
            }

            partOrder.Note = editePartOrderDto.Note == null ? partOrder.Note : editePartOrderDto.Note;
            partOrder.PartId = editePartOrderDto.PartId == null ? partOrder.PartId : editePartOrderDto.PartId;
            partOrder.Quantity = editePartOrderDto.Quantity == null ? partOrder.Quantity : editePartOrderDto.Quantity;
            partOrder.SuplierId = editePartOrderDto.SuplierId == null ? partOrder.SuplierId : editePartOrderDto.SuplierId;

            await _dbContext.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// Returns if delivery exists.
        /// </summary>
        /// <param name="deliveryId"></param>
        /// <returns>bool</returns
        public async Task<bool> DeliveryExists(int deliveryId)
        {
            return await _dbContext.Delivaries
                .Where(d => d.Id == deliveryId && d.IsDeleted == false)
                .AnyAsync();
        }

        /// <summary>
        /// Returns if suplier exists.
        /// </summary>
        /// <param name="suplierId"></param>
        /// <returns>bool</returns
        public async Task<bool> SuplierExists(int suplierId)
        {
            return await _dbContext.Supliers
                .Where(s => s.Id == suplierId && s.IsDeleted == false)
                .AnyAsync();
        }

        /// <summary>
        /// Returns if partOrder exists.
        /// </summary>
        /// <param name="partOrderId"></param>
        /// <returns>bool</returns
        public async Task<bool> PartOrderExists(int partOrderId)
        {
            return await _dbContext.PartOrders
                .Where(po => po.Id == partOrderId && po.IsDeleted == false)
                .AnyAsync();
        }

        /// <summary>
        /// Gets all avaiable parts in database
        /// </summary>
        /// <returns>Dto's collection of all avaiable parts in database</returns>
        public async Task<PartQueryDto> AllPartsInStock()//int currentPage
        {
            //int deliveriesPerPage = 6;

            var result = new PartQueryDto();

            try
            {
                result.Parts = await _dbContext.Parts
                .AsNoTracking()
                .Include(p => p.ImagesParts)
                //.Skip((currentPage - 1) * deliveriesPerPage)
                //.Take(deliveriesPerPage)
                .Select(p => new PartDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    OEMNumber = p.OEMNumber,
                    Intend = p.Intend,
                    Description = p.Description,
                    Type = p.Type,
                    Quantity = (int)p.Quantity,
                    Category = p.Category.Name,
                    Rating = (int)Math.Ceiling(p.Rates
                                    .Where(r => r.PartId == p.Id)
                                    .Select(r => r.Rating)
                                    .Average()) == null
                                    ? 0
                                    : (int)Math.Ceiling(p.Rates
                                    .Where(r => r.PartId == p.Id)
                                    .Select(r => r.Rating)
                                    .Average()),
                    SalePrice = p.SalePrice,
                    ImageUrls = p.ImagesParts.Where(p => p.PartId == p.Id)
                    .Select(ip => ip.ImageUrl).ToList()
                })
                .ToListAsync();


                result.TotalPartsCount = await _dbContext.Parts
                            .AsNoTracking()
                            .Where(p => p.IsDeleted == false && p.DateDeleted.Equals(null))
                            .CountAsync();

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("Database can't retrive data", ex);
            }
        }

        public async Task<ICollection<PartDto>> GetAllSuplierPartsInStock(int suplierId)
        {
            try
            {
                var suplierPartsIds = _dbContext.PartsInStock
                .AsNoTracking()
                .Where(spi => spi.SuplierId == suplierId)
                .Select(spi=> spi.PartId)
                .ToList();

                var result = await _dbContext.Parts
                .AsNoTracking()
                .Include(p => p.ImagesParts)
                .Where(p=>suplierPartsIds.Contains(p.Id))
                .Select(p => new PartDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    OEMNumber = p.OEMNumber,
                    Intend = p.Intend,
                    Description = p.Description,
                    Type = p.Type,
                    Quantity = (int)p.Quantity,
                    Category = p.Category.Name,
                    Rating = (int)Math.Ceiling(p.Rates
                                    .Where(r => r.PartId == p.Id)
                                    .Select(r => r.Rating)
                                    .Average()) == null
                                    ? 0
                                    : (int)Math.Ceiling(p.Rates
                                    .Where(r => r.PartId == p.Id)
                                    .Select(r => r.Rating)
                                    .Average()),
                    SalePrice = p.SalePrice,
                    ImageUrls = p.ImagesParts.Where(p => p.PartId == p.Id)
                    .Select(ip => ip.ImageUrl).ToList()
                })
                .ToListAsync();

                return result;

            }
            catch (Exception ex)
            {

                throw new Exception("Database can't retrive data", ex);
            }
        }


        //public Task UpdateSuplierPartsInStock(int suplierId, int[] suppliedPartsOemNums)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
