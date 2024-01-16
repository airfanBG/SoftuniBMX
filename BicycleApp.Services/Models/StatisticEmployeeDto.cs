namespace BicycleApp.Services.Models
{    
    public class StatisticEmployeeDto
    {
        public int TotalWorkedMinutes  { get; set; }
        public int TotalWorkedOrders  { get; set; }

        public string BestWorkerName  { get; set; } = null!;
        public string BestWorkerDepartment { get; set; } = null!;
        public string BestWorkerSubDepartment { get; set; } = null!;
        public int BestWorkerWorkedOrders { get; set; } 
        public int BestWorkerWorkedMinutes { get; set; }
        public string BestWorkerWorkedImageUrl { get; set; } = null!;
    }
}
