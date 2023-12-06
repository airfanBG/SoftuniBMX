

namespace BicycleApp.Services.Models.Supply
{
    public class AllDeliveriesQueryModel
    {

        public const int DeliveriesPerPage = 2;

        public string? Supplier { get; set; }

        public string? SearchTerm { get; set; }

        public DeliveriesSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public double TotalDeliveriesCount { get; set; }
        public IEnumerable<DeliveryDetailsDto> Deliveries { get; set; } = Enumerable.Empty<DeliveryDetailsDto>();
    }
}
