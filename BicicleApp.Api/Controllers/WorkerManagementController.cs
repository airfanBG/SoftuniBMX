namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.WorkerManagement;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/worker_management")]
    [ApiController]
    public class WorkerManagementController : ControllerBase
    {
        private readonly IWorkerManagement workerМanagement;
        public WorkerManagementController(IWorkerManagement workerМanagement)
        {
            this.workerМanagement = workerМanagement;
        }

        public async Task<IActionResult> EmployeeSalaryCalculation([FromBody] TotalSalary totalSalary)
        {
            var result = await workerМanagement.EmployeeSalaryCalculation(totalSalary);

            return Ok(result);
        }
    }
}
