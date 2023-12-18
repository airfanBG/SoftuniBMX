namespace BicycleApp.Services.Services.Order
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BicycleApp.Data;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Models.IdentityModels;
    using BicycleApp.Services.Models.Order;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.ApplicationGlobalConstants;

    public class EmployeeOrderService : IEmployeeOrderService
    {
        private readonly BicycleAppDbContext dbContext;
        private readonly UserManager<Employee> userManager;
        private readonly IEmployeeFactory employeeFactory;

        public EmployeeOrderService(BicycleAppDbContext dbContext, UserManager<Employee> userManager, IEmployeeFactory employeeFactory)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
            this.employeeFactory = employeeFactory;
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
                && ope.EmployeeId == partOrdersStartEndDto.EmployeeId
                && ope.OrderId == partOrdersStartEndDto.OrderId);

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
                && ope.EmployeeId == partOrdersStartEndDto.EmployeeId
                && ope.OrderId == partOrdersStartEndDto.OrderId);

            if (order == null)
            {
                return false;
            }

            order.EndDatetime = DateTime.Parse(partOrdersStartEndDto.DateTime);
            order.IsCompleted = true;
            var mainOrder = await dbContext.Orders
                .Where(o => o.Id == order.OrderId)
                .FirstAsync();
            mainOrder.StatusId = 7;

            TimeSpan partProductionTime = (TimeSpan)(order.EndDatetime - order.StartDatetime);
            TimeSpan minimumSpan = TimeSpan.Parse("00:00:00.0000000");

            if (partOrdersStartEndDto != null && partProductionTime > minimumSpan)
            {
                var partInfo = await employeeFactory.CreateOrderPartEmployeeInfo(partProductionTime, order.OrderId, order.UniqueKeyForSerialNumber, order.PartId);

                await dbContext.OrdersPartsEmployeesInfos.AddAsync(partInfo);
                await dbContext.SaveChangesAsync();

                return true;
            }

            return false;
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
            .Include(opei => opei.OrdersPartsEmployeesInfos)
            .Where(ep => ep.EmployeeId == employeeId && ep.EndDatetime == null && ep.IsCompleted == false)
            .OrderBy(o => o.OrderId)
            .Select(p => new PartOrdersDto()
            {
                PartId = p.PartId,
                OrderId = p.OrderId,
                PartName = p.Part.Name,
                PartOEMNumber = p.Part.OEMNumber,
                DatetimeAsigned = p.DatetimeAsigned.Value.ToString(DefaultDateWithTimeFormat),
                DatetimeStarted = p.StartDatetime.Value.ToString(DefaultDateWithTimeFormat),
                DatetimeFinished = null,
                Description = p.OrdersPartsEmployeesInfos.Where(o => p.OrderId == o.OrderId && p.PartId == o.PartId && p.UniqueKeyForSerialNumber == o.UniqueKeyForSerialNumber).OrderBy(id => id.Id).LastOrDefault().DescriptionForWorker,
                OrderSerialNumber = p.SerialNumber,
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
