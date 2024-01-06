namespace BicycleApp.Services.Services
{
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models;
    using BicycleApp.Services.Models.ManagerStatistics;
    using BicycleApp.Services.Models.Order.OrderManager;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Query;
    using System.Threading.Tasks;

    public class ManagerSatisticsService : IManagerSatisticsService
    {
        private readonly BicycleAppDbContext _db;
        private readonly IDateTimeProvider _dateTimeProvider;
        public ManagerSatisticsService(BicycleAppDbContext db, IDateTimeProvider dateTimeProvider)
        {
            _db = db;
            _dateTimeProvider = dateTimeProvider;
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
        public async Task<OrderStatisticDto> GetOrderStatistics(FinishedOrdersDto datesPeriod)
        {
            return await _db.Orders
                .AsNoTracking()
                .Select(o => new OrderStatisticDto
                {
                    TotalIncome = _db.Orders.Sum(o => o.SaleAmount),
                    TotalSendedOrdersCount = _db.Orders.Count(),
                    IncomeForSelectedPeriod = _db.Orders.Where(o => o.DateCreated >= datesPeriod.StartDate
                                     && o.DateFinish <= datesPeriod.EndDate.AddDays(1)
                                     && o.DateFinish != null
                                     && o.DateDeleted == null).Sum(o => o.SaleAmount),
                    SendedOrdersCountForSelectedPeriod = _db.Orders.Where(o => o.DateCreated >= datesPeriod.StartDate
                                     && o.DateFinish <= datesPeriod.EndDate.AddDays(1)
                                     && o.DateFinish != null
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
                    OrderedCount = group.Select(pqy => pqy.PartQuantity).Count(),//.Sum().Aggregate((sum, val) => sum + val),//OrderedCount
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
                    BestselerPartOrderedCount = group.Select(pq => pq.PartQuantity).Count(),
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
                TotalBestselerPartOrderedCount = bestSelerPart.OrderedCount,
                TotalBestselerPartIncome = bestSelerPart.PartIncome,
                BestselerPartName = bestSelerPartForPeriod.BestselerPartName,
                BestselerPartId = bestSelerPartForPeriod.BestselerPartId,
                BestselerPartOrderedCount = bestSelerPartForPeriod.BestselerPartOrderedCount,
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
