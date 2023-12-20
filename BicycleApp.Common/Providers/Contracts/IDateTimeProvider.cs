namespace BicicleApp.Common.Providers.Contracts
{
    using BicycleApp.Common.Models;

    public interface IDateTimeProvider
    {
        public DateTime Now { get; }
        public PreviousMonthData PreviousMonthObject { get; }
    }
}
