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
    using BicycleApp.Services.Models.Order;
    using BicycleApp.Services.Contracts.Factory;

    public class QualityAssuranceService : IQualityAssuranceService
    {
        private readonly BicycleAppDbContext _db;
        private readonly IStringManipulator _stringManipulator;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IEmployeeFactory _employeeFactory;
        public QualityAssuranceService(BicycleAppDbContext db, IStringManipulator stringManipulator, IDateTimeProvider dateTimeProvider, IEmployeeFactory employeeFactory)
        {
            _db = db;
            _stringManipulator = stringManipulator;
            _dateTimeProvider = dateTimeProvider;
            _employeeFactory = employeeFactory;
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

        public async Task<RemanufacturingPartEmployeeInfoDto?> RemanufacturingPart(RemanufacturingOrderPartDto remanufacturingOrderPartDto)
        {
            try
            {
                var partToManufacturing = await _db.OrdersPartsEmployees
                                                   .Include(e => e.Employee)
                                                   .FirstAsync(ope => ope.OrderId == remanufacturingOrderPartDto.OrderId 
                                                                                           && ope.PartId == remanufacturingOrderPartDto.PartId);

                partToManufacturing.StartDatetime = null;
                partToManufacturing.EndDatetime = null;
                partToManufacturing.Description = _stringManipulator.GetTextFromProperty(remanufacturingOrderPartDto.Description);
                partToManufacturing.IsCompleted = false;

                var employeeName = _stringManipulator.ReturnFullName(partToManufacturing.Employee.FirstName, partToManufacturing.Employee.LastName);

                await _db.SaveChangesAsync();

                var partToManufacturingView = _employeeFactory.CreateRemanufacturingOrderPart(employeeName, partToManufacturing.PartName, partToManufacturing.SerialNumber, partToManufacturing.Description);

                return partToManufacturingView;
            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}
