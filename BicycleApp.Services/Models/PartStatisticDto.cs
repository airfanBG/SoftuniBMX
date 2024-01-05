namespace BicycleApp.Services.Models
{    
    public class PartStatisticDto
    {
        public string BestselerPartNameTotal { get; set; } = null!;
        public string BestselerPartOemNumTotal { get; set; } = null!;
        public int BestselerPartSoldTotal { get; set; }
        public decimal BestselerPartTotalIncome { get; set; }
        public string BestselerPartName { get; set; } = null!;
        public string BestselerPartOemNum { get; set; } = null!;
        public int BestselerSold { get; set; }
        public decimal BestselerIncome { get; set; }
    }
}
