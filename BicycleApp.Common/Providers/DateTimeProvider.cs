namespace BicycleApp.Common
{
    using BicicleApp.Common.Providers.Contracts;
    using System;

    public class DateTimeProvider : IDateTimeProvider
    {
        public virtual DateTime Now => DateTime.UtcNow;
    }
}
