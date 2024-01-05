namespace BicycleApp.Services.Services
{
    using BicycleApp.Common.Providers.Contracts;
    using static BicycleApp.Common.ApplicationGlobalConstants;
    using BicycleApp.Data;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Models.WorkerManagement;
    using BicycleApp.Services.Models.WorkerManagement.Contracts;
    using Microsoft.EntityFrameworkCore;
    using BicycleApp.Services.HelperClasses.Contracts;

    public class WorkerManagement: IWorkerManagement
    {
        private readonly BicycleAppDbContext _db;
        private readonly IOptionProvider _optionProvider;
        private readonly IEmployeeFactory _employeeFactory;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IStringManipulator _stringManipulator;
        public WorkerManagement(BicycleAppDbContext db, IOptionProvider optionProvider, IEmployeeFactory employeeFactory, IDateTimeProvider dateTimeProvider, IStringManipulator stringManipulator)
        {
            _db = db;
            _optionProvider = optionProvider;
            _employeeFactory = employeeFactory;
            _dateTimeProvider = dateTimeProvider;
            _stringManipulator = stringManipulator;
        }

        public async Task<SalaryOverview> EmployeeSalaryCalculation(ITotalSalary baseSalary)
        {
            var isSalaryAccruedCurrentMonth = await IsSalaryAccruedCurrentMonth();
            if (baseSalary.Bonus >= 0 && isSalaryAccruedCurrentMonth)
            {
                try
                {
                    var salaryAccrualPercentagesValues = _optionProvider.GetSalaryAccrualPercentages();
                    var employee = await _db.Employees
                                            .AsNoTracking()
                                            .Include(es => es.EmployeeMonthSalaryInfos)
                                            .FirstAsync(e => e.Id == baseSalary.EmployeeId);

                    int internshipInBMX = employee.EmployeeMonthSalaryInfos.Count;
                    int allInternshipMonths = employee.InternshipInMonths + internshipInBMX;
                    decimal internshipRate = salaryAccrualPercentagesValues.InternshipRate;

                    var currentDate = _dateTimeProvider.Now;
                    var internshipValue = InternshipValueCalculation(employee.BaseSalary, allInternshipMonths, internshipRate);

                    var salaryInfo = _employeeFactory.CreateEmployeeMonthSalaryInfo(employee.BaseSalary, internshipValue, baseSalary.Bonus, salaryAccrualPercentagesValues, employee.Id, currentDate);

                    await _db.EmployeesMonthsSalariesInfos.AddAsync(salaryInfo);
                    await _db.SaveChangesAsync();

                    return new SalaryOverview()
                    {
                        TotalSalary = salaryInfo.BaseSalary + salaryInfo.InternshipValue + salaryInfo.MonthBonus,
                        CurrentMonth = salaryInfo.Month.ToString(DefaultDateFormat),
                        EmployeeId = salaryInfo.EmployeeId,
                        EmployeeName = _stringManipulator.ReturnFullName(employee.FirstName, employee.LastName)
                    };

                }
                catch (Exception)
                {
                }
            }

            return null;
        }

        private async Task<bool> IsSalaryAccruedCurrentMonth()
        {
            var currentDate = _dateTimeProvider.Now;
            var currentMonthAccruedCheck = await _db.EmployeesMonthsSalariesInfos.FirstOrDefaultAsync(x => x.Month.Month == currentDate.Month && x.Month.Year == currentDate.Year);
            if (currentMonthAccruedCheck != null)
            {
                return false;
            }

            return true;
        }

        private decimal InternshipValueCalculation(decimal baseSalary, int internshipMonths, decimal internshipRate)
        {
            int internshipYears = internshipMonths / 12;
            decimal internshipAllYearsRate = internshipYears * internshipRate;
            decimal internshipValue = Math.Round((baseSalary * (internshipAllYearsRate / 100)), 2);

            return internshipValue;
        }
    }
}
