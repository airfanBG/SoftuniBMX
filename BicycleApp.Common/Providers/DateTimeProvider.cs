namespace BicycleApp.Common
{
    using BicicleApp.Common.Providers.Contracts;
    using System;

    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime Now => DateTime.UtcNow;
    }
}
