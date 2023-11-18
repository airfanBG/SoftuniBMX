namespace BicycleApp.Services.Services.Order
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BicycleApp.Data;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.Order;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.ApplicationGlobalConstants;

    public class EmployeeOrderService : IEmployeeOrderService
    {
        private readonly BicycleAppDbContext dbContext;
        private readonly UserManager<Employee> userManager;

        public EmployeeOrderService(BicycleAppDbContext dbContext, UserManager<Employee> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        /// <summary>
        /// This method changes the start datetime of an order by employee
        /// </summary>
        /// <param name="partOrdersStartEndDto">Input info</param>
        /// <returns>True/False</returns>
        public async Task<bool> StartOrderByEmployee(PartOrdersStartEndDto partOrdersStartEndDto)
        {
            var order = await dbContext.OrdersPartsEmployees
                .FirstOrDefaultAsync(ope => ope.PartId == partOrdersStartEndDto.PartId
                && ope.EmployeeId == partOrdersStartEndDto.EmployeeId);

            if (order == null)
            {
                return false;
            }

            order.StartDatetime = DateTime.Parse(partOrdersStartEndDto.DateTime);

            await dbContext.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// This method changes the end datetime of an order by employee 
        /// </summary>
        /// <param name="partOrdersStartEndDto">Input info</param>
        /// <returns>True/False</returns>
        public async Task<bool> EndOrderByEmployee(PartOrdersStartEndDto partOrdersStartEndDto)
        {
            var order = await dbContext.OrdersPartsEmployees
                .FirstOrDefaultAsync(ope => ope.PartId == partOrdersStartEndDto.PartId
                && ope.EmployeeId == partOrdersStartEndDto.EmployeeId);

            if (order == null)
            {
                return false;
            }

            order.EndDatetime = DateTime.Parse(partOrdersStartEndDto.DateTime);
            order.IsCompleted = true;

            await dbContext.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// This method returns all the orders asigned to a one employee that are not finished
        /// </summary>
        /// <param name="employeeId">Id of the employee</param>
        /// <returns>Dto with the employee id and collection of orders</returns>
        /// <exception cref="NullReferenceException">Is the If is null</exception>
        /// <exception cref="ArgumentException">If there is no employee with that Id</exception>
        public async Task<EmployeePartOrdersDto> GetAllOrdersAsignedToEmployee(string employeeId)
        {
            if (employeeId == null)
            {
                throw new NullReferenceException(nameof(employeeId));
            }

            var employeeExists = await userManager.FindByIdAsync(employeeId);

            if (employeeExists == null)
            {
                throw new ArgumentException($"Employee with {employeeId} does not exists!");
            }

            var orders = await dbContext.OrdersPartsEmployees
                .Include(ep => ep.Part)
                .Include(ep => ep.Order)
                .Where(ep => ep.EmployeeId == employeeId && ep.EndDatetime == null && ep.IsCompleted == false)
                .Select(p => new PartOrdersDto()
                {
                    PartId = p.PartId,
                    PartName = p.Part.Name,
                    PartOEMNumber = p.Part.OEMNumber,
                    DatetimeAsigned = p.DatetimeAsigned.Value.ToString(DefaultDateWithTimeFormat),
                    DatetimeFinished = null,
                    Description = p.Description,
                    OrderSerialNumber = p.Order.SerialNumber,
                    Quantity = p.PartQuantity
                })
                .ToListAsync();

            EmployeePartOrdersDto ordersDto = new EmployeePartOrdersDto()
            {
                EmployeeId = employeeId,
                Orders = orders
            };

            return ordersDto;
        }

    }
}
