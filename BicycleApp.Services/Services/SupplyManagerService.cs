using Azure;
using BicicleApp.Common.Providers.Contracts;
using BicycleApp.Data;
using BicycleApp.Data.Models.EntityModels;
using BicycleApp.Services.Contracts;
using BicycleApp.Services.Models;
using BicycleApp.Services.Models.Supply;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BicycleApp.Services.Services
{
    public class SupplyManagerService : ISupplyManagerService
    {

        private readonly BicycleAppDbContext _dbContext;
        private readonly IModelsFactory _modelsFactory;
        private readonly IDateTimeProvider _dateTimeProvider;

        public SupplyManagerService(BicycleAppDbContext dbContext, IModelsFactory modelsFactory)
        {
            _dbContext = dbContext;
            _modelsFactory = modelsFactory;
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
                    PartCategoryName = s.CategoryName,
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

        public async Task<bool> CreateDelivedry(CreateDelivedryDto createDelivedryDto)// here I have to update partsQuantity in Db!
        {
            if (createDelivedryDto == null)
            {
                return false;
            }

            try
            {
                var delivery = _modelsFactory.CreateNewDelivery(createDelivedryDto);

                await _dbContext.Delivaries.AddAsync(delivery);

                await _dbContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Database can't save data", ex);
            }
        }

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
                var deliveryToReject = await _dbContext.Supliers.FirstAsync(o => o.Id == deliveryId);
                deliveryToReject.DateDeleted = _dateTimeProvider.Now;
                deliveryToReject.IsDeleted = true;

                _dbContext.Supliers.Update(deliveryToReject);
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
                    SuplierId = p.SuplierId
                })
                .FirstAsync();

                return result;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Database can't retrive data", ex);
            }

        }

        public async Task<SuplierDetailsDto> SuplierDetailsById(int suplierId)//Has to shows avaiable parts!
        {


            if (suplierId <= 0)
            {
                throw new ArgumentNullException(nameof(suplierId));
            }

            try
            {
                var result = await _dbContext.Supliers
                .AsNoTracking()
                .Include(p => p.PartsInStock)
                .Include(p => p.PartsInOrder)
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
                    //OrderParts = p.PartsInStock
                    //.Where(p => p.SuplierId == suplierId)//да го измисля по просто !
                    //.Select(pis => new PartInStockInfoDto
                    //{
                    //    Id = pis.Id,
                    //    OemNumber = pis.OemPartNumber,
                    //    SuplierId = pis.SuplierId,

                    //}).ToList(),
                })
                .FirstAsync();

                return result;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Database can't retrive data", ex);
            }
        }
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

        public Task UpdateSuplierPartsInStock(int suplierId, int[] suppliedPartsOemNums)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> DeliveryExists(int deliveryId)
        {
            return await _dbContext.Delivaries
                .Where(d => d.Id == deliveryId && d.IsDeleted == false)
                .AnyAsync();
        }
        public async Task<bool> SuplierExists(int suplierId)
        {
            return await _dbContext.Supliers
                .Where(s => s.Id == suplierId && s.IsDeleted == false)
                .AnyAsync();
        }
    }
}
