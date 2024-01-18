namespace BicycleApp.Services.Services.ManagerServices
{
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models.ManagerStatistics;
    using BicycleApp.Services.Models.Order.OrderManager;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;

    using static BicycleApp.Common.Constants.UserConstants;

    public class ManagerSatisticsService : IManagerSatisticsService
    {
        private readonly BicycleAppDbContext _db;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IStringManipulator _stringManipulator;
        private readonly IImageStore _imageStore;
        public ManagerSatisticsService(BicycleAppDbContext db,
            IDateTimeProvider dateTimeProvider,
            IStringManipulator stringManipulator,
            IImageStore imageStore)
        {
            _db = db;
            _dateTimeProvider = dateTimeProvider;
            _stringManipulator = stringManipulator;
            _imageStore = imageStore;
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

        public async Task<StatisticEmployeeDto> EmployeeFullStatistics(string httpScheme, string httpHost, string httpPathBase)
        {

            var totalWorkedMinutes = await GetTotalWorkedMinutesAsync();

            var totalWorkedOrders = await GetTotalWorkedOrdersAsync();

            var bestWorker = await GetBestWorkerAsync();

            var bestEmployeeId = bestWorker.EmployeeId;

            var bestWorkerName = _stringManipulator.ReturnFullName(bestWorker.FirstName, bestWorker.LastName);

            var employeeImgUrl = await _imageStore.GetUserImage(bestEmployeeId, EMPLOYEE, httpScheme, httpHost, httpPathBase);

            var employeeFullStatistics = new StatisticEmployeeDto()
            {
                TotalWorkedMinutes = totalWorkedMinutes,
                TotalWorkedOrders = totalWorkedOrders,
                BestWorkerName = bestWorkerName,
                BestWorkerDepartment = bestWorker.DepartmentName,
                BestWorkerSubDepartment = bestWorker.SubDepartmentName,
                BestWorkerWorkedOrders = bestWorker.WorkedOrdersCount,
                BestWorkerWorkedMinutes = bestWorker.WorkedTime,
                BestWorkerWorkedImageUrl = employeeImgUrl
            };

            return employeeFullStatistics;
        }

        private async Task<dynamic> GetBestWorkerAsync()
        {

            return await _db.OrdersPartsEmployeesInfos
               .AsNoTracking()
               .Include(ope => ope.OrderPartEmployee)
               .ThenInclude(e => e.Employee)
               .ThenInclude(d => d.Department)
               .Where(opei => opei.DescriptionForWorker == null
                           && opei.OrderPartEmployee.DateFinish != null
                           && opei.OrderPartEmployee.DateDeleted == null)
               .GroupBy(opei => opei.OrderPartEmployee.Part.CategoryId)
               .Select(group => new
               {
                   PartCategoryId = group.Key,
                   WorkedTime = group.Select(x => x.ProductionТime.Minutes).Sum(),
                   WorkedOrdersCount = group.Select(x => x.OrderId).Count(),
                   EmployeeId = group.Select(x => x.OrderPartEmployee.EmployeeId).First().ToString(),
                   FirstName = group.Select(x => x.OrderPartEmployee.Employee.FirstName).First().ToString(),
                   LastName = group.Select(x => x.OrderPartEmployee.Employee.LastName).First().ToString(),
                   DepartmentName = group.Select(x => x.OrderPartEmployee.Employee.Department.Name).First().ToString(),
                   SubDepartmentName = group.Select(x => x.OrderPartEmployee.Part.Category.Name).First().ToString(),
               })
               .OrderByDescending(group => group.WorkedTime)
               .FirstAsync();

        }

        private async Task<int> GetTotalWorkedMinutesAsync()
        {
            return await _db.OrdersPartsEmployees
                .AsNoTracking()
                .Include(opei => opei.OrdersPartsEmployeesInfos)
                .Where(ope => ope.DateFinish != null
                              && ope.DateDeleted == null)
                .SelectMany(x => x.OrdersPartsEmployeesInfos.Select(x => x.ProductionТime))
                .SumAsync(x => x.Minutes);
        }

        private async Task<int> GetTotalWorkedOrdersAsync()
        {
            return await _db.OrdersPartsEmployees
                .Where(ope => ope.DateFinish != null
                              && ope.DateDeleted == null)
                .CountAsync();
        }

        public async Task<StatisticEmployeeDto> EmployeePeriodStatistics(FinishedOrdersDto datesPeriod, string httpScheme, string httpHost, string httpPathBase)
        {
            var bestPeriodWorker = await GetBestPeriodWorkerAsync(datesPeriod);
            var bestPeriodEmployeeId = bestPeriodWorker.EmployeeId;

            var bestPeriodWorkerName = _stringManipulator.ReturnFullName(bestPeriodWorker.FirstName, bestPeriodWorker.LastName);

            var employeeImgUrl = await _imageStore.GetUserImage(bestPeriodEmployeeId, EMPLOYEE, httpScheme, httpHost, httpPathBase);

            var periodWorkedMinutes = await GetPeriodWorkedMinutesAsync(datesPeriod);

            var periodWorkedOrders = await GetPeriodWorkedOrdersAsync(datesPeriod);

            var employeePeriodStatistics = new StatisticEmployeeDto()
            {
                TotalWorkedMinutes = periodWorkedMinutes,
                TotalWorkedOrders = periodWorkedOrders,
                BestWorkerName = bestPeriodWorkerName,
                BestWorkerDepartment = bestPeriodWorker.DepartmentName,
                BestWorkerSubDepartment = bestPeriodWorker.SubDepartmentName,
                BestWorkerWorkedOrders = bestPeriodWorker.WorkedOrdersCount,
                BestWorkerWorkedMinutes = bestPeriodWorker.WorkedTime,
                BestWorkerWorkedImageUrl = employeeImgUrl
            };

            return employeePeriodStatistics;
        }

        private async Task<dynamic> GetBestPeriodWorkerAsync(FinishedOrdersDto datesPeriod)
        {

            return await _db.OrdersPartsEmployeesInfos
                    .AsNoTracking()
                    .Include(ope => ope.OrderPartEmployee)
                    .ThenInclude(e => e.Employee)
                    .ThenInclude(d => d.Department)
                    .Where(opei => opei.DescriptionForWorker == null
                                && opei.OrderPartEmployee.DateFinish >= datesPeriod.StartDate
                        && opei.OrderPartEmployee.DateFinish <= datesPeriod.EndDate.AddDays(1)
                                && opei.OrderPartEmployee.DateFinish != null
                                && opei.OrderPartEmployee.DateDeleted == null)
                    .GroupBy(opei => opei.OrderPartEmployee.Part.CategoryId)
                    .Select(group => new
                    {
                        PartCategoryId = group.Key,
                        WorkedTime = group.Select(x => x.ProductionТime.Minutes).Sum(),
                        WorkedOrdersCount = group.Select(x => x.OrderId).Count(),
                        EmployeeId = group.Select(x => x.OrderPartEmployee.EmployeeId).First().ToString(),
                        FirstName = group.Select(x => x.OrderPartEmployee.Employee.FirstName).First().ToString(),
                        LastName = group.Select(x => x.OrderPartEmployee.Employee.LastName).First().ToString(),
                        DepartmentName = group.Select(x => x.OrderPartEmployee.Employee.Department.Name).First().ToString(),
                        SubDepartmentName = group.Select(x => x.OrderPartEmployee.Part.Category.Name).First().ToString(),
                    })
                    .OrderByDescending(group => group.WorkedTime)
                    .FirstAsync();

        }

        private async Task<int> GetPeriodWorkedMinutesAsync(FinishedOrdersDto datesPeriod)
        {
            return await _db.OrdersPartsEmployees
                .AsNoTracking()
                .Include(opei => opei.OrdersPartsEmployeesInfos)
                .Where(ope => ope.DateFinish >= datesPeriod.StartDate
                    && ope.DateFinish <= datesPeriod.EndDate.AddDays(1)
                    && ope.DateFinish != null
                    && ope.DateDeleted == null)
                .Where(ope => ope.DateFinish != null && ope.DateDeleted == null)
                .SelectMany(x => x.OrdersPartsEmployeesInfos.Select(x => x.ProductionТime))
                .SumAsync(x => x.Minutes);
        }

        private async Task<int> GetPeriodWorkedOrdersAsync(FinishedOrdersDto datesPeriod)
        {
            return await _db.Orders
                .Where(o => o.DateFinish >= datesPeriod.StartDate
                    && o.DateFinish <= datesPeriod.EndDate.AddDays(1)
                    && o.DateFinish != null
                    && o.DateDeleted == null)
                .CountAsync();
        }

        public async Task<EmployeeStatisticsDto> GetEmployeesStatistics(FinishedOrdersDto datesPeriod, string httpScheme, string httpHost, string httpPathBase)
        {

            var result = new EmployeeStatisticsDto()
            {
                EmployeeFullStatistics = await EmployeeFullStatistics(httpScheme, httpHost, httpPathBase),
                EmployeePeriodStatistics = await EmployeePeriodStatistics(datesPeriod, httpScheme, httpHost, httpPathBase),
            };

            return result;
        }

        public async Task<StatisticsDto> GetStatistics(FinishedOrdersDto datesPeriod)
        {

            var result = new StatisticsDto
            {
                OrderStatistics = await GetOrderStatistics(datesPeriod),
                TotalPartStatistics = await GetTotalPartStatistics(),
                PeriodPartStatistics = await GetPeriodPartStatistics(datesPeriod),
            };

            return result;
        }

        public async Task<OrderStatisticDto> GetOrderStatistics(FinishedOrdersDto datesPeriod)
        {
            var totalIncomeQuery = _db.Orders
                .Where(o => o.DateFinish != null
                            && o.DateSended != null
                            && o.DateDeleted == null);

            var incomeForSelectedPeriodQuery = totalIncomeQuery
                .Where(o => o.DateCreated >= datesPeriod.StartDate
                && o.DateFinish <= datesPeriod.EndDate.AddDays(1)
);
            var orderStatisticDto = new OrderStatisticDto
            {
                TotalIncome = await totalIncomeQuery.SumAsync(o => o.SaleAmount),
                TotalSendedOrdersCount = await totalIncomeQuery.CountAsync(),
                IncomeForSelectedPeriod = await incomeForSelectedPeriodQuery.SumAsync(o => o.SaleAmount),
                SendedOrdersCountForSelectedPeriod = await incomeForSelectedPeriodQuery.CountAsync()
            };

            return orderStatisticDto;
        }

        public async Task<PartStatisticDto> GetTotalPartStatistics()
        {
            var bestSelerParts = await _db.OrdersPartsEmployees
                .AsNoTracking()
                .Include(ope => ope.Order)
                .Include(o => o.Part)
                .ThenInclude(x => x.ImagesParts)
                .Where(o => o.DateFinish != null
                         && o.Order.DateSended != null
                         && o.DateDeleted == null)
                .ToListAsync();


            var result = bestSelerParts
                .GroupBy(ope => ope.PartId)
                .Select(group => new PartStatisticDto
                {
                    PartId = group.Key,
                    PartName = group.Select(gn => gn.PartName).First(),
                    SerialNumber = group.Select(gn => gn.SerialNumber).First(),
                    PartSoldCount = group.Select(pqy => Convert.ToInt32(pqy.PartQuantity)).Sum(),
                    PartIncome = group.Select(pinc => pinc.PartPrice).Sum(),
                    ImageUrl = _db.ImagesParts.Where(ip => ip.PartId == group.Key).Select(ip => ip.ImageUrl).First().ToString(),
                    GroupCount = group.Count(),
                })
                .OrderByDescending(og => og.GroupCount)
                .FirstOrDefault();


            return result;
        }

        public async Task<PartStatisticDto> GetPeriodPartStatistics(FinishedOrdersDto datesPeriod)
        {
            var bestSelerParts = await _db.OrdersPartsEmployees
                .AsNoTracking()
                .Include(ope => ope.Order)
                .Include(o => o.Part)
                .ThenInclude(x => x.ImagesParts)
                .Where(o => o.DateFinish != null
                         && o.Order.DateSended != null
                         && o.DateDeleted == null)
                .ToListAsync();


            var result = bestSelerParts
               .Where(o => o.DateFinish >= datesPeriod.StartDate
                                         && o.DateFinish <= datesPeriod.EndDate.AddDays(1))
               .GroupBy(ope => ope.PartId)
               .Select(group => new PartStatisticDto
               {

                   PartId = group.Key,
                   PartName = group.Select(gn => gn.PartName).First(),
                   SerialNumber = group.Select(gn => gn.SerialNumber).First(),
                   PartSoldCount = group.Select(pqy => Convert.ToInt32(pqy.PartQuantity)).Sum(),
                   PartIncome = group.Select(pinc => pinc.PartPrice).Sum(),
                   ImageUrl = _db.ImagesParts.Where(ip => ip.PartId == group.Key).Select(ip => ip.ImageUrl).First().ToString(),
                   GroupCount = group.Count(),
               })
               .OrderByDescending(og => og.GroupCount)
               .FirstOrDefault();


            return result;

        }

    }
}
