namespace BicycleApp.Common
{
    using BicicleApp.Common.Providers.Contracts;
    using System;

    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTimeOffset Now => DateTimeOffset.Now;
    }
}
