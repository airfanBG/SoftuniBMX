namespace BicycleApp.Services.Services.Orders
{
    using BicycleApp.Data;
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models.Order.OrderUser;
    using static BicycleApp.Common.ApplicationGlobalConstants;

    using Microsoft.EntityFrameworkCore;

    using System.Threading.Tasks;
    using BicicleApp.Common.Providers.Contracts;

    public class QualityAssuranceService : IQualityAssuranceService
    {
        private readonly BicycleAppDbContext _db;
        private readonly IStringManipulator _stringManipulator;
        private readonly IDateTimeProvider _dateTimeProvider;
        public QualityAssuranceService(BicycleAppDbContext db, IStringManipulator stringManipulator, IDateTimeProvider dateTimeProvider)
        {
            _db = db;
            _stringManipulator = stringManipulator;
            _dateTimeProvider = dateTimeProvider;
        }

        /// <summary>
        /// Returns all orders, whitch are ready for quality essurance.
        /// </summary>
        /// <returns>Task<ICollection<OrderProgretionDto>></returns>
        public async Task<ICollection<OrderProgretionDto>> GetAllReadyOrder()
        {
            return await _db.Orders
                            .AsNoTracking()
                            .Where(o => o.DateFinish == null 
                                        && o.IsDeleted == false
                                        && o.OrdersPartsEmployees.Where(ope => ope.OrderId == o.Id).All(ope => ope.IsCompleted == true))
                            .Select(o => new OrderProgretionDto()
                            {
                                OrderId = o.Id,
                                DateCreated = o.DateCreated.ToString(DefaultDateWithTimeFormat),
                                OrderStates = o.OrdersPartsEmployees
                                               .Select(ope => new OrderStateDto()
                                               {
                                                   PartId = ope.PartId,
                                                   PartModel = ope.PartName,
                                                   PartType = ope.Part.Category.Name,
                                                   NameOfEmplоyeeProducedThePart = _stringManipulator.ReturnFullName(ope.Employee.FirstName, ope.Employee.LastName),
                                                   EmployeeId = ope.EmployeeId,
                                                   SerialNumber = ope.SerialNumber,
                                                   IsProduced = ope.IsCompleted
                                               })
                                               .ToList()
                            })
                            .ToListAsync();
        }

        /// <summary>
        /// Quality of the order is assured and prepair for send to the customer.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>Task<bool></returns>
        public async Task<bool> OrderPassQualityAssurance(int orderId)
        {
            try
            {
                var passedOrder = await _db.Orders.FirstAsync(o => o.Id == orderId);
                passedOrder.StatusId++;
                passedOrder.DateFinish = _dateTimeProvider.Now;

                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }
    }
}
