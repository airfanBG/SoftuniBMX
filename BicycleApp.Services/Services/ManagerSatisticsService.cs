namespace BicycleApp.Services.Services
{
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models;
    using BicycleApp.Services.Models.ManagerStatistics;
    using BicycleApp.Services.Models.Order.OrderManager;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Query;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Xaml.Permissions;

    public class ManagerSatisticsService : IManagerSatisticsService
    {
        private readonly BicycleAppDbContext _db;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IStringManipulator _stringManipulator;
        public ManagerSatisticsService(BicycleAppDbContext db, 
            IDateTimeProvider dateTimeProvider,
            IStringManipulator stringManipulator)
        {
            _db = db;
            _dateTimeProvider = dateTimeProvider;
            _stringManipulator = stringManipulator;
        }

        public async Task<PastAndCurrentEmployeeWorkingMinutesDto> GetEmployeeOutputForThePastAndCurrentMonth(string employeeId)
        {
            var pastMonthValue = _dateTimeProvider.PreviousMonthObject;
            var currentMonthValue = _dateTimeProvider.Now;

            var pastMonthEmployeeWorkingMinutes = await _db.OrdersPartsEmployees
                                                           .AsNoTracking()
                                                           .Where(e => e.EmployeeId == employeeId
                                                                       && e.StartDatetime.Value.Month == pastMonthValue.PreviousMonth
                                                                       && e.StartDatetime.Value.Year == pastMonthValue.PreviousYear)
                                                           .SelectMany(a => a.OrdersPartsEmployeesInfos.Select(x => x.ProductionТime))
                                                           .SumAsync(a => a.Minutes);

            var currentMonthEmployeeWorkingMinutes = await _db.OrdersPartsEmployees
                                                           .AsNoTracking()
                                                           .Where(e => e.EmployeeId == employeeId
                                                                       && e.StartDatetime.Value.Month == currentMonthValue.Month
                                                                       && e.StartDatetime.Value.Year == currentMonthValue.Year)
                                                           .SelectMany(a => a.OrdersPartsEmployeesInfos.Select(x => x.ProductionТime))
                                                           .SumAsync(a => a.Minutes);

            var pastAndCurrentEmployeeWorkingMinutes = new PastAndCurrentEmployeeWorkingMinutesDto()
            {
                PastMonthEmployeeWorkingMinutes = pastMonthEmployeeWorkingMinutes,
                CurrentMonthEmployeeWorkingMinutes = currentMonthEmployeeWorkingMinutes
            };


            return pastAndCurrentEmployeeWorkingMinutes;
        }


        public async Task<StatisticEmployeeDto> EmployeeFullStatistics()
        {
            //BestWorker(without descriptions from QA with max worked time)
            var bestWorker = await _db.OrdersPartsEmployeesInfos
                .AsNoTracking()
                .Include(ope => ope.OrderPartEmployee)
                .Where(ope => ope.OrderPartEmployee.DateFinish != null
                            && ope.OrderPartEmployee.DateDeleted == null)
                .Where(opei => opei.DescriptionForWorker == null)
                .GroupBy(opei => opei.OrderPartEmployee.Part.CategoryId)
                .Select(group => new
                {
                    PartCategoryId = group.Key,
                    WorkedTime = group.Select(x => x.ProductionТime.Minutes).Sum(),
                    WorkedOrdersCount = group.Select(x => x.OrderId).Count(),
                })
                .OrderByDescending(group => group.WorkedTime)
                .Take(1)
                .FirstAsync();

            var bestEmployeeId = await _db.Parts
                .AsNoTracking()
                .Where(p => p.CategoryId == bestWorker.PartCategoryId)
                .Select(p => p.OrdersPartsEmployees.Select(ope => ope.EmployeeId))
                .Take(1)
                .FirstAsync();

            string bestEmployeId = bestEmployeeId.FirstOrDefault();


            var totalWorkedMinutes = await _db.OrdersPartsEmployees
                .AsNoTracking()
                .Include(opei => opei.OrdersPartsEmployeesInfos)
                .Where(ope => ope.DateFinish != null
                            && ope.DateDeleted == null)
                .SelectMany(x => x.OrdersPartsEmployeesInfos.Select(x => x.ProductionТime))
                .SumAsync(x => x.Minutes);


            var totalWorkedOrders = _db.OrdersPartsEmployees.Where(ope => ope.DateFinish != null
                  && ope.DateDeleted == null).Count();

            var ourProudWorker = await _db.ImagesEmployees
                .AsNoTracking()
                .Include(x => x.Employee)
                .Where(x => x.UserId == bestEmployeId)
                .Select(x => new
                {
                    Name = _stringManipulator.ReturnFullName(x.Employee.FirstName, x.Employee.LastName),
                    DepartmentName = x.Employee.Department.Name,
                    EmployeeImgUrl = x.ImageUrl
                }).FirstAsync();

            var subDepartmentName = await _db.Parts.Where(p => p.CategoryId == bestWorker.PartCategoryId).Select(x => x.Category.Name).FirstAsync();

            var employeeFullStatistics = new StatisticEmployeeDto()
            {
                TotalWorkedMinutes = totalWorkedMinutes,
                TotalWorkedOrders = totalWorkedOrders,
                ProudWorkerName = ourProudWorker.Name,
                ProudWorkerDepartment = ourProudWorker.DepartmentName,
                ProudWorkerSubDepartment = subDepartmentName,
                ProudWorkerWorkedOrders = bestWorker.WorkedOrdersCount,
                ProudWorkerWorkedMinutes = bestWorker.WorkedTime,
                ProudWorkerWorkedImageUrl = ourProudWorker.EmployeeImgUrl
            };

            return employeeFullStatistics;
        }

        public async Task<StatisticEmployeeDto> EmployeePeriodStatistics(FinishedOrdersDto datesPeriod)
        {
            //BestWorkerForPeriod
            var bestPeriodWorker = await _db.OrdersPartsEmployeesInfos
                .AsNoTracking()
                .Include(ope => ope.OrderPartEmployee)
                .Where(ope => ope.OrderPartEmployee.DateCreated >= datesPeriod.StartDate
                       && ope.OrderPartEmployee.DateFinish <= datesPeriod.EndDate.AddDays(1)
                       && ope.OrderPartEmployee.DateFinish != null
                       && ope.OrderPartEmployee.DateDeleted == null)
                .Where(opei => opei.DescriptionForWorker == null)
                .GroupBy(opei => opei.OrderPartEmployee.Part.CategoryId)
                .Select(group => new
                {
                    PartCategoryId = group.Key,
                    WorkedTime = group.Select(x => x.ProductionТime.Minutes).Sum(),
                    WorkedOrdersCount = group.Select(x => x.OrderId).Count(),
                })
                .OrderByDescending(group => group.WorkedTime)
                .Take(1)
                .FirstAsync();

            var periodWorkedMinutes = await _db.OrdersPartsEmployees
                .AsNoTracking()
                .Include(opei => opei.OrdersPartsEmployeesInfos)
                .Where(ope => ope.DateCreated >= datesPeriod.StartDate
                       && ope.DateFinish <= datesPeriod.EndDate.AddDays(1)
                       && ope.DateFinish != null
                       && ope.DateDeleted == null)
                .Where(ope => ope.DateFinish != null
                            && ope.DateDeleted == null)
                .SelectMany(x => x.OrdersPartsEmployeesInfos.Select(x => x.ProductionТime))
                .SumAsync(x => x.Minutes);

            var periodEmployeeId = await _db.Parts
                .AsNoTracking()
                .Where(p => p.CategoryId == bestPeriodWorker.PartCategoryId)
                .Select(x => x.OrdersPartsEmployees.Select(x => x.EmployeeId))
                .FirstAsync();

            string periodEmployeId = periodEmployeeId.FirstOrDefault();

            var periodWorkedOrders = _db.Orders
                .Where(o => o.DateCreated >= datesPeriod.StartDate
                && o.DateFinish <= datesPeriod.EndDate.AddDays(1)
                && o.DateFinish != null
                && o.DateDeleted == null).Count();

            var ourPeriodWorker = await _db.ImagesEmployees
                .AsNoTracking()
                .Include(x => x.Employee)
                .Where(ie => ie.UserId == periodEmployeId.ToString())
                .Select(x => new
                {
                    Name = _stringManipulator.ReturnFullName(x.Employee.FirstName, x.Employee.LastName),
                    DepartmentName = x.Employee.Department.Name,
                    EmployeeImgUrl = x.ImageUrl
                }).FirstAsync();

            var subDepartmentPeriodName = await _db.Parts.Where(p => p.CategoryId == bestPeriodWorker.PartCategoryId).Select(x => x.Category.Name).FirstAsync();

            var employeePeriodStatistics = new StatisticEmployeeDto()
            {
                TotalWorkedMinutes = periodWorkedMinutes,
                TotalWorkedOrders = periodWorkedOrders,
                ProudWorkerName = ourPeriodWorker.Name,
                ProudWorkerDepartment = ourPeriodWorker.DepartmentName,
                ProudWorkerSubDepartment = subDepartmentPeriodName,
                ProudWorkerWorkedOrders = bestPeriodWorker.WorkedOrdersCount,
                ProudWorkerWorkedMinutes = bestPeriodWorker.WorkedTime,
                ProudWorkerWorkedImageUrl = ourPeriodWorker.EmployeeImgUrl
            };

            return employeePeriodStatistics;
        }

        public async Task<EmployeeStatisticsDto> GetEmployeesStatistics(FinishedOrdersDto datesPeriod)
        {

            var result = new EmployeeStatisticsDto()
            {
                EmployeeFullStatistics = await EmployeeFullStatistics(),
                EmployeePeriodStatistics = await EmployeePeriodStatistics(datesPeriod),
            };
            ;
            return result;

        }

        public async Task<OrderStatisticDto> GetOrderStatistics(FinishedOrdersDto datesPeriod)
        {
            return await _db.Orders
                .AsNoTracking()
                .Select(o => new OrderStatisticDto
                {
                    TotalIncome = _db.Orders.Where(o=>o.DateFinish != null
                                     && o.DateSended != null
                                     && o.DateDeleted == null).Sum(o => o.SaleAmount),
                    TotalSendedOrdersCount = _db.Orders.Where(o=>o.DateFinish != null
                                     && o.DateSended != null
                                     && o.DateDeleted == null).Count(),
                    IncomeForSelectedPeriod = _db.Orders.Where(o => o.DateCreated >= datesPeriod.StartDate
                                     && o.DateFinish <= datesPeriod.EndDate.AddDays(1)
                                     && o.DateFinish != null
                                     && o.DateSended != null
                                     && o.DateDeleted == null).Sum(o => o.SaleAmount),
                    SendedOrdersCountForSelectedPeriod = _db.Orders.Where(o => o.DateCreated >= datesPeriod.StartDate
                                     && o.DateFinish <= datesPeriod.EndDate.AddDays(1)
                                     && o.DateFinish != null
                                     && o.DateSended != null
                                     && o.DateDeleted == null).Count()
                })
                .FirstAsync();

        }
        public async Task<PartStatisticDto> GetPartStatistics(FinishedOrdersDto datesPeriod)
        {

            var bestSelerPart = await _db.OrdersPartsEmployees
                .GroupBy(ope => ope.PartId)
                .Select(group => new
                {
                    PartId = group.Key,
                    PartName = group.Select(gn => gn.PartName).First(),
                    SoldCount = group.Select(pqy => Convert.ToInt32(pqy.PartQuantity)).Sum(),
                    PartIncome = group.Select(pinc => pinc.PartPrice).Sum(),
                    GroupCount = group.Count(),

                })
                .OrderByDescending(og => og.GroupCount)
                .Take(1)
                .FirstAsync();

            var bestSelerPartForPeriod = await _db.OrdersPartsEmployees
                .AsNoTracking()
                .Where(o => o.DateCreated >= datesPeriod.StartDate
                                     && o.DateFinish <= datesPeriod.EndDate.AddDays(1)
                                     && o.DateFinish != null
                                     && o.DateDeleted == null)
                .GroupBy(ope => ope.PartId)
                .Select(group => new
                {
                    BestselerPartId = group.Key,
                    BestselerPartName = group.Select(gn => gn.PartName).First(),
                    BestselerPartSoldCount = group.Select(pq => Convert.ToInt32(pq.PartQuantity)).Sum(),
                    BestselerPartIncome = group.Select(pinc => pinc.PartPrice).Sum(),
                    GroupCount = group.Count()

                })
                .OrderByDescending(og => og.GroupCount)
                .Take(1)
                .FirstAsync();

            var result = new PartStatisticDto
            {
                TotalBestselerPartId = bestSelerPart.PartId,
                TotalBestselerPartName = bestSelerPart.PartName,
                TotalBestselerPartSoldCount = bestSelerPart.SoldCount,
                TotalBestselerPartIncome = bestSelerPart.PartIncome,
                BestselerPartName = bestSelerPartForPeriod.BestselerPartName,
                BestselerPartId = bestSelerPartForPeriod.BestselerPartId,
                BestselerPartSoldCount = bestSelerPartForPeriod.BestselerPartSoldCount,
                BestselerPartIncome = bestSelerPartForPeriod.BestselerPartIncome,

            };

            return result;

        }

        public async Task<StatisticsDto> GetStatistics(FinishedOrdersDto datesPeriod)
        {
            var result = new StatisticsDto
            {
                OrderStatistics = await GetOrderStatistics(datesPeriod),
                PartStatistics = await GetPartStatistics(datesPeriod)
            };

            return result;
        }
    }
}
