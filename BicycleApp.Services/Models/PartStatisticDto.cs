namespace BicycleApp.Services.Models
{    
    public class PartStatisticDto
    {
        public string TotalBestselerPartName { get; set; } = null!;
        public int TotalBestselerPartId { get; set; } 
        public int TotalBestselerPartSoldCount { get; set; }
        public decimal TotalBestselerPartIncome { get; set; }
        public string BestselerPartName { get; set; } = null!;
        public int BestselerPartId { get; set; } 
        public int BestselerPartSoldCount { get; set; }
        public decimal BestselerPartIncome { get; set; }
    }
}
