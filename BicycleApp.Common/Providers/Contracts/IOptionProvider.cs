namespace BicycleApp.Common.Providers.Contracts
{
    public interface IOptionProvider
    {
        public string? ClientDefautPassword();
        public string? EmailAccoutUsername();
        public string? EmailAccoutPassword();
        public string? ClientEmailConfirmEnpoint();
        public string? EmployeeEmailConfirmEnpoint();
        string? GetPreviousWorkerPositionName(string currentWorkerPosition);
        public string? GetDefaultUserRelativePath();
    }
}
