namespace BicycleApp.Common.Providers
{
    using BicycleApp.Common.Providers.Contracts;
    using Microsoft.Extensions.Configuration;

    public class OptionProvider : IOptionProvider
    {
        private readonly IConfiguration _configuration;

        public OptionProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string? ClientDefautPassword()
        {
            return _configuration.GetSection("ClientDefautPassword").Value;
        }       

        public string? EmailAccoutPassword()
        {
            return _configuration.GetSection("Email:Password").Value;
        }

        public string? EmailAccoutUsername()
        {
            return _configuration.GetSection("Email:Sender").Value;
        }
        public string? ClientEmailConfirmEnpoint()
        {
            return _configuration.GetSection("RegisterEmailConfirmEndPoint:Client").Value;
        }

        public string? EmployeeEmailConfirmEnpoint()
        {
            return _configuration.GetSection("RegisterEmailConfirmEndPoint:Employee").Value;
        }
    }
}
