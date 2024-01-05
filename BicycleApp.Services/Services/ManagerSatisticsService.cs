namespace BicycleApp.Services.Services
{
    using BicicleApp.Common.Providers.Contracts;
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.ManagerStatistics;
    using BicycleApp.Services.Models.ManagerStatistics.Contracts;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class ManagerSatisticsService : IManagerSatisticsService
    {
        private readonly BicycleAppDbContext _db;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IOptionProvider _optionProvider;
        public ManagerSatisticsService(BicycleAppDbContext db, IDateTimeProvider dateTimeProvider, IOptionProvider optionProvider)
        {
            _db = db;
            _dateTimeProvider = dateTimeProvider;
            _optionProvider = optionProvider;
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

        public async Task<SalaryOverview> EmployeeSalaryCalculation(IBaseSalary baseSalary)
        {
            //try
            //{
            //    var employee = await _db.Employees
            //                            .Include(es => es.EmployeeMonthSalaryInfos)
            //                            .FirstAsync(e => e.Id == baseSalary.EmployeeId);

            //    int internshipInBMX = employee.EmployeeMonthSalaryInfos.Count;
            //    int allInternshipMonths = employee.InternshipInMonths + internshipInBMX;
            //    decimal internshipRate = _optionProvider.


            //    var internshipValue = InternshipValueCalculation(employee.BaseSalary, allInternshipMonths, );

            //}
            //catch (Exception)
            //{
            //}

            throw new NotImplementedException();
        }

        private decimal InternshipValueCalculation(decimal baseSalary, int internshipMonths, decimal internshipRate)
        {
            throw new NotImplementedException();
        }
    }
}
