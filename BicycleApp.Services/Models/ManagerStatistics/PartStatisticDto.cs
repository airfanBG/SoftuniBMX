﻿namespace BicycleApp.Services.Models.ManagerStatistics
{
    public class PartStatisticDto
    {
        public string PartName { get; set; } = null!;
        public string SerialNumber { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public int PartId { get; set; }
        public int PartSoldCount { get; set; }
        public int GroupCount { get; set; }
        public decimal PartIncome { get; set; }

    }
}
