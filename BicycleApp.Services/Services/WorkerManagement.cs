namespace BicycleApp.Services.Services
{
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.WorkerManagement;
    using BicycleApp.Services.Models.WorkerManagement.Contracts;
    using Microsoft.EntityFrameworkCore;

    public class WorkerManagement: IWorkerManagement
    {
        private readonly BicycleAppDbContext _db;
        private readonly IOptionProvider _optionProvider;
        public WorkerManagement(BicycleAppDbContext db, IOptionProvider optionProvider)
        {
            _db = db;
            _optionProvider = optionProvider;
        }

        public async Task<SalaryOverview> EmployeeSalaryCalculation(ITotalSalary baseSalary)
        {
            var salaryAccrualPercentagesValues = _optionProvider.GetSalaryAccrualPercentages();

            try
            {
                var employee = await _db.Employees
                                        .Include(es => es.EmployeeMonthSalaryInfos)
                                        .FirstAsync(e => e.Id == baseSalary.EmployeeId);

                int internshipInBMX = employee.EmployeeMonthSalaryInfos.Count;
                int allInternshipMonths = employee.InternshipInMonths + internshipInBMX;
                decimal internshipRate = salaryAccrualPercentagesValues.InternshipRate;

                var internshipValue = InternshipValueCalculation(employee.BaseSalary, allInternshipMonths, internshipRate);

                return new SalaryOverview();
            }
            catch (Exception)
            {
            }
            return null;
        }

        private decimal InternshipValueCalculation(decimal baseSalary, int internshipMonths, decimal internshipRate)
        {
            throw new NotImplementedException();
        }
    }
}
