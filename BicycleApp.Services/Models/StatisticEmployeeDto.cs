namespace BicycleApp.Services.Models
{    
    public class StatisticEmployeeDto
    {
        public int TotalWorkedMinutes  { get; set; }
        public int TotalWorkedOrders  { get; set; }

        public string ProudWorkerName  { get; set; } = null!;
        public string ProudWorkerDepartment   { get; set; } = null!;
        public string ProudWorkerSubDepartment    { get; set; } = null!;
        public int ProudWorkerWorkedOrders     { get; set; } 
        public int ProudWorkerWorkedMinutes  { get; set; }
        public string ProudWorkerWorkedImageUrl  { get; set; } = null!;
    }
}
