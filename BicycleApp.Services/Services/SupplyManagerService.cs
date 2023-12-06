using BicycleApp.Data;
using BicycleApp.Services.Contracts;
using BicycleApp.Services.Models.Supply;
using Microsoft.EntityFrameworkCore;

namespace BicycleApp.Services.Services
{
    public class SupplyManagerService : ISupplyManagerService
    {

        private readonly BicycleAppDbContext _dbContext;

        public SupplyManagerService(BicycleAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<DeliveryQueryDto> AllDeliveries(string suplier = null, 
                                                    string searchTerm = null, 
                                                    DeliveriesSorting sorting = DeliveriesSorting.Newest, 
                                                    int currentPage = 1, 
                                                    int deliveriesPerPage = 1)
        {

            var result = new DeliveryQueryDto();

            var deliveries = _dbContext.Delivaries
               .Where(v => v.IsDeleted == false);


            if (!string.IsNullOrEmpty(suplier))
            {
                deliveries = deliveries
                    .Where(d => d.Suplier.Name == suplier);
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                searchTerm = $"%{searchTerm.ToLower()}";
                deliveries = deliveries
                    .Where(d => EF.Functions.Like(d.Part.Name.ToLower(), searchTerm) ||
                   EF.Functions.Like(d.Suplier.Name.ToLower(), searchTerm) ||
                   EF.Functions.Like(d.Note.ToLower(), searchTerm));

            }

            switch (sorting)
            {
                case DeliveriesSorting.Supplier:
                    deliveries = deliveries.OrderBy(d => d.Suplier.Name);
                    break;
                case DeliveriesSorting.PartName:
                    deliveries = deliveries.OrderByDescending(d => d.Part.Name);
                    break;
                default:
                    deliveries = deliveries.OrderByDescending(d => d.Id);
                    break;
            }

            result.Deliveries = await deliveries
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

            result.TotalDeliveriesCount = await deliveries.CountAsync();


            return result;
        }

        public Task<SupplierInfoDto> AllSuppliers()
        {
            throw new NotImplementedException();
        }

        public Task CreateDelivedry(CreateDelivedryDto createDelivedryDto)
        {
            throw new NotImplementedException();
        }

        public Task CreateSuplier(CreateSuplierDto createSuplierDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDelivedry(int deliveryId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSuplier(int suplierId)
        {
            throw new NotImplementedException();
        }

        public Task<DeliveryDetailsDto> DeliveryDetails(int deliveryId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeliveryExists(int deliveryId)
        {
            throw new NotImplementedException();
        }

        public Task EditDelivedry(int vehicleId, CreateDelivedryDto createDelivedryDto)
        {
            throw new NotImplementedException();
        }

        public Task EditSuplier(int suplierId, CreateSuplierDto createSuplierDto)
        {
            throw new NotImplementedException();
        }

        public Task<SuplierDetailsDto> SuplierDetails(int suplierId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SuplierExists(int suplierId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSuplierPartsInStock(int suplierId, int[] suppliedPartsOemNums)
        {
            throw new NotImplementedException();
        }
    }
}
