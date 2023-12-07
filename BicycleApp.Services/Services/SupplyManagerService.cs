using Azure;
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
        public async Task<DeliveryQueryDto> AllDeliveries(int currentPage)
        {
            int deliveriesPerPage = 6;

            var result = new DeliveryQueryDto();

            result.Deliveries  = await _dbContext.Delivaries.AsQueryable()
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
