namespace BicycleApp.Common.Providers
{
    using BicycleApp.Common.Providers.Contracts;

    public class GuidProvider : IGuidProvider
    {
        public string CreateGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
