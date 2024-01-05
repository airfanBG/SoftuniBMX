namespace BicycleApp.Services.Models.Order.OrderManager
{
    public class OrderStatisticDto
    {
        public decimal TotalIncome { get; set; }
        public int TotalSendedOrdersCount { get; set; }
        public decimal IncomeForSelectedPeriod { get; set; }
        public int SendedOrdersCountForSelectedPeriod { get; set; }
    }
}
