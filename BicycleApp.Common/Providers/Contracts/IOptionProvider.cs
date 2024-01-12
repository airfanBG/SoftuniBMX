namespace BicycleApp.Common.Providers.Contracts
{
    using BicycleApp.Common.Models;

    public interface IOptionProvider
    {
        public string? ClientDefautPassword();
        public string? EmailAccoutUsername();
        public string? EmailAccoutPassword();
        public string? ClientEmailConfirmEnpoint();
        public string? EmployeeEmailConfirmEnpoint();
        public string? GetPreviousWorkerPositionName(string currentWorkerPosition);
        public SalaryAccrualPercentages GetSalaryAccrualPercentages();
        public string GetDefaultAvatarRelativePath();
    }
}
