namespace BicicleApp.Common.Providers.Contracts
{
    public interface IDateTimeProvider
    {
        public DateTimeOffset Now { get; }
    }
}
