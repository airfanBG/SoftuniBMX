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
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;

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
                                                   IsProduced = ope.IsCompleted,
                                                   ElementProduceTimeInMinutes = ope.OrdersPartsEmployeesInfos.Where(opei => opei.OrderId == ope.OrderId 
                                                                                                               && opei.PartId == ope.PartId 
                                                                                                               && opei.UniqueKeyForSerialNumber == ope.UniqueKeyForSerialNumber)
                                                                                                     .Sum(opeis => opeis.ProductionТime.Minutes)
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
        public async Task<int> OrderPassQualityAssurance(int orderId)
        {
            try
            {
                var passedOrder = await _db.Orders.FirstAsync(o => o.Id == orderId);
                passedOrder.StatusId++;
                passedOrder.DateFinish = _dateTimeProvider.Now;

                await _db.SaveChangesAsync();
                return passedOrder.Id;
            }
            catch (Exception)
            {
            }
            return 0;
        }

        /// <summary>
        /// Returns a manufactured part back to the worker.
        /// </summary>
        /// <param name="remanufacturingOrderPartDto"></param>
        /// <returns>Task<RemanufacturingPartEmployeeInfoDto?></returns>
        public async Task<ICollection<RemanufacturingPartEmployeeInfoDto>> RemanufacturingPart(IOrderProgretionDto orderProgretionDto)
        {
            try
            {
                var returnedParts = new List<RemanufacturingPartEmployeeInfoDto>();

                foreach (var orderState in orderProgretionDto.OrderStates)
                {
                    if (!orderState.IsProduced)
                    {
                        var partToManufacturing = await _db.OrdersPartsEmployees
                                                  .Include(e => e.Employee)
                                                  .Include(opei => opei.OrdersPartsEmployeesInfos)
                                                  .FirstAsync(ope => ope.OrderId == orderProgretionDto.OrderId
                                                                                          && ope.PartId == orderState.PartId);

                        partToManufacturing.StartDatetime = null;
                        partToManufacturing.EndDatetime = null;

                        var descriptionFromQualityControl = partToManufacturing.OrdersPartsEmployeesInfos
                                                                           .LastOrDefault(o => o.OrderId == orderProgretionDto.OrderId
                                                                                       && o.PartId == orderState.PartId);
                        descriptionFromQualityControl.DescriptionForWorker = orderState.Description;
                        partToManufacturing.IsCompleted = false;
                        var employeeName = _stringManipulator.ReturnFullName(partToManufacturing.Employee.FirstName, partToManufacturing.Employee.LastName);

                        _db.OrdersPartsEmployees.Update(partToManufacturing);

                        var partToManufacturingView = _employeeFactory.CreateRemanufacturingOrderPart(employeeName, partToManufacturing.PartName, partToManufacturing.SerialNumber, orderState.Description);

                        returnedParts.Add(partToManufacturingView);
                    }

                }
                await _db.SaveChangesAsync();

                return returnedParts;
            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}
