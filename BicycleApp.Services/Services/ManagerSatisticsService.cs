namespace BicycleApp.Services.Services
{
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models;
    using BicycleApp.Services.Models.ManagerStatistics;
    using BicycleApp.Services.Models.Order.OrderManager;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;

    using static BicycleApp.Common.UserConstants;

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
            var bestWorker = await GetBestWorkerAsync();

            var bestEmployeeId = await GetBestEmployeeIdAsync(bestWorker.PartCategoryId);

            var totalWorkedMinutes = await GetTotalWorkedMinutesAsync();

            var totalWorkedOrders = await GetTotalWorkedOrdersAsync();

            var ourProudWorker = await GetOurProudWorkerAsync(bestEmployeeId, httpScheme, httpHost, httpPathBase);

            var subDepartmentName = await GetSubDepartmentNameAsync(bestWorker.PartCategoryId);

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

        private async Task<dynamic> GetBestWorkerAsync()
        {
            return await _db.OrdersPartsEmployeesInfos
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
        }

        private async Task<string> GetBestEmployeeIdAsync(int partCategoryId)
        {
            var bestEmployeeId = await _db.Parts
                .AsNoTracking()
                .Where(p => p.CategoryId == partCategoryId)
                .Select(p => p.OrdersPartsEmployees.Select(ope => ope.EmployeeId))
                .Take(1)
                .FirstAsync();

            return bestEmployeeId.FirstOrDefault();
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

        private async Task<dynamic> GetOurProudWorkerAsync(string bestEmployeeId, string httpScheme, string httpHost, string httpPathBase)
        {
            return await _db.Employees
                .AsNoTracking()
                .Where(x => x.Id == bestEmployeeId)
                .Select(x => new
                {
                    Name = _stringManipulator.ReturnFullName(x.FirstName, x.LastName),
                    DepartmentName = x.Department.Name,
                    EmployeeImgUrl = _imageStore.GetUserImage(bestEmployeeId.ToString(), EMPLOYEE, httpScheme, httpHost, httpPathBase).Result
                })
                .FirstAsync();
        }

        private async Task<string> GetSubDepartmentNameAsync(int partCategoryId)
        {
            return await _db.Parts
                .Where(p => p.CategoryId == partCategoryId)
                .Select(x => x.Category.Name)
                .FirstAsync();
        }

        public async Task<StatisticEmployeeDto> EmployeePeriodStatistics(FinishedOrdersDto datesPeriod, string httpScheme, string httpHost, string httpPathBase)
        {
            var bestPeriodWorker = await GetBestPeriodWorkerAsync(datesPeriod);

            var periodWorkedMinutes = await GetPeriodWorkedMinutesAsync(datesPeriod);

            var periodEmployeeId = await GetPeriodEmployeeIdAsync(bestPeriodWorker.PartCategoryId);

            var periodWorkedOrders = await GetPeriodWorkedOrdersAsync(datesPeriod);

            var ourPeriodWorker = await GetOurPeriodWorkerAsync(periodEmployeeId, httpScheme, httpHost, httpPathBase);

            var subDepartmentPeriodName = await GetSubDepartmentPeriodNameAsync(bestPeriodWorker.PartCategoryId);

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

        private async Task<dynamic> GetBestPeriodWorkerAsync(FinishedOrdersDto datesPeriod)
        {
            return await _db.OrdersPartsEmployeesInfos
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
        }

        private async Task<int> GetPeriodWorkedMinutesAsync(FinishedOrdersDto datesPeriod)
        {
            return await _db.OrdersPartsEmployees
                .AsNoTracking()
                .Include(opei => opei.OrdersPartsEmployeesInfos)
                .Where(ope => ope.DateCreated >= datesPeriod.StartDate
                    && ope.DateFinish <= datesPeriod.EndDate.AddDays(1)
                    && ope.DateFinish != null
                    && ope.DateDeleted == null)
                .Where(ope => ope.DateFinish != null && ope.DateDeleted == null)
                .SelectMany(x => x.OrdersPartsEmployeesInfos.Select(x => x.ProductionТime))
                .SumAsync(x => x.Minutes);
        }

        private async Task<string> GetPeriodEmployeeIdAsync(int partCategoryId)
        {
            var periodEmployeeId = await _db.Parts
                .AsNoTracking()
                .Where(p => p.CategoryId == partCategoryId)
                .Select(x => x.OrdersPartsEmployees.Select(x => x.EmployeeId))
                .FirstAsync();

            return periodEmployeeId.FirstOrDefault();
        }

        private async Task<int> GetPeriodWorkedOrdersAsync(FinishedOrdersDto datesPeriod)
        {
            return await _db.Orders
                .Where(o => o.DateCreated >= datesPeriod.StartDate
                    && o.DateFinish <= datesPeriod.EndDate.AddDays(1)
                    && o.DateFinish != null
                    && o.DateDeleted == null)
                .CountAsync();
        }

        private async Task<dynamic> GetOurPeriodWorkerAsync(string periodEmployeeId, string httpScheme, string httpHost, string httpPathBase)
        {
            return await _db.Employees
                .AsNoTracking()
                .Where(e => e.Id == periodEmployeeId)
                .Select(x => new
                {
                    Name = _stringManipulator.ReturnFullName(x.FirstName, x.LastName),
                    DepartmentName = x.Department.Name,
                    EmployeeImgUrl = _imageStore.GetUserImage(periodEmployeeId, EMPLOYEE, httpScheme, httpHost, httpPathBase).Result
                })
                .FirstAsync();
        }

        private async Task<string> GetSubDepartmentPeriodNameAsync(int partCategoryId)
        {
            return await _db.Parts
                .Where(p => p.CategoryId == partCategoryId)
                .Select(x => x.Category.Name)
                .FirstAsync();
        }

       
        public async Task<EmployeeStatisticsDto> GetEmployeesStatistics(FinishedOrdersDto datesPeriod, string httpScheme, string httpHost, string httpPathBase)
        {

            var result = new EmployeeStatisticsDto()
            {
                EmployeeFullStatistics = await EmployeeFullStatistics(httpScheme, httpHost, httpPathBase),
                EmployeePeriodStatistics = await EmployeePeriodStatistics(datesPeriod, httpScheme, httpHost, httpPathBase),
            };
            ;
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
