namespace BicycleApp.Tests.Services.Factory
{
    using BicycleApp.Common.Models;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Models.IdentityModels;
    using BicycleApp.Services.Models.Order;
    using BicycleApp.Services.Services.Factory;
    using Newtonsoft.Json;

    public class EmployeeFactoryTest
    {
        private readonly IEmployeeFactory _employeeFactory;

        public EmployeeFactoryTest()
        {
            _employeeFactory = new EmployeeFactory();
        }

        [Test]
        public void CreateOrderPartEmployeeInfo_ShouldReturnOrderPartEmployeeInfo()
        {
            //Arrange
            TimeSpan partProductionTime = new TimeSpan(0, 5, 0);
            int orderId = 1;
            string uniqueKeyForSerialNumber = Guid.NewGuid().ToString();
            int partId = 1;

            OrderPartEmployeeInfo expected = new OrderPartEmployeeInfo
            {
                OrderId = orderId,
                UniqueKeyForSerialNumber = uniqueKeyForSerialNumber,
                ProductionТime = partProductionTime,
                PartId = partId                
            };
            string expectedObject = JsonConvert.SerializeObject(expected);

            //Act
            var actual = _employeeFactory.CreateOrderPartEmployeeInfo(partProductionTime, orderId, uniqueKeyForSerialNumber, partId);
            string actualObject = JsonConvert.SerializeObject(actual);

            //Assert
            Assert.AreEqual(expectedObject, actualObject);
        }

        [Test]
        public void CreateRemanufacturingOrderPart_ShouldReturnRemanufacturingPartEmployeeInfoDto()
        {
            //Arrange
            string employeeName = "Test Test";
            string serialNumber = "BIDTEST";
            string description = "Test description";
            string partName = "Test part name";

            RemanufacturingPartEmployeeInfoDto expected = new RemanufacturingPartEmployeeInfoDto
            {
                EmployeeName = employeeName,
                SerialNumber = serialNumber,
                Description = description,
                PartName = partName
            };
            string expectedObject = JsonConvert.SerializeObject(expected);

            //Act
            var actual = _employeeFactory.CreateRemanufacturingOrderPart(employeeName, partName, serialNumber, description);
            string actualObject = JsonConvert.SerializeObject(actual);

            //Assert
            Assert.AreEqual(expectedObject, actualObject);
        }

        [Test]
        [TestCase(1500, 0, 0)]
        [TestCase(1499.99, 0, 0)]
        [TestCase(1500.01, 0, 0)]
        [TestCase(1500, 1, 200)]
        [TestCase(1500.99, 1.99, 200.99)]
        public void CreateEmployeeMonthSalaryInfo_ShouldReturnCorrectResult(decimal baseSalary, decimal internshipValue, decimal monthBonus)
        {
            //Arrange
            decimal testBaseSalary = baseSalary;
            decimal testInternshipValue = internshipValue;
            decimal testMonthBonus = monthBonus;
            SalaryAccrualPercentages salaryAccrualPercentages = new SalaryAccrualPercentages
            {
                DOO = 8.38M,
                DZPO = 2.20M,
                ZO = 3.2M,
                DDFL = 10.00M,
                InternshipRate = 0.6M
            };

            string employeeId = Guid.NewGuid().ToString();
            DateTime currentDate = new DateTime(2024, 11, 11);

            decimal totalSalary = testBaseSalary + testInternshipValue + testMonthBonus;

            decimal dooValue = Math.Round((totalSalary * (salaryAccrualPercentages.DOO / 100)), 2);
            decimal dzpoValue = Math.Round((totalSalary * (salaryAccrualPercentages.DZPO / 100)), 2);
            decimal zoValue = Math.Round((totalSalary * (salaryAccrualPercentages.ZO / 100)), 2);

            decimal totalInsurance = dooValue + dzpoValue + zoValue;

            decimal taxableAmount = totalSalary - totalInsurance;

            decimal ddflValue = Math.Round((taxableAmount * (salaryAccrualPercentages.DDFL / 100)), 2);

            decimal netSalaryValue = totalSalary - totalInsurance - ddflValue;

            EmployeeMonthSalaryInfo employeeMonthSalaryInfo = new EmployeeMonthSalaryInfo()
            {
                EmployeeId = employeeId,
                BaseSalary = baseSalary,
                InternshipValue = internshipValue,
                MonthBonus = monthBonus,
                DOO = dooValue,
                DZPO = dzpoValue,
                ZO = zoValue,
                DDFL = ddflValue,
                NetSalary = netSalaryValue,
                Month = currentDate
            };
            string expectedObject = JsonConvert.SerializeObject(employeeMonthSalaryInfo);

            //Act
            var actual = _employeeFactory.CreateEmployeeMonthSalaryInfo(testBaseSalary,testInternshipValue, testMonthBonus,salaryAccrualPercentages, employeeId, currentDate);
            string actualObject = JsonConvert.SerializeObject(actual);
            //Assert
            Assert.AreEqual(netSalaryValue, actual.NetSalary);
            Assert.AreEqual(expectedObject, actualObject);
        }

        [Test]
        public void CreateEmployeeSalaryInfoDto_ShouldReturnEmployeeSalaryInfoDto()
        {
            //Arrange
            decimal baseSalary = 1500.00M;
            decimal internshipValue = 200.00M;
            decimal monthBonus = 133.00M;
            decimal doo = 222.00M;
            decimal dzpo = 222.00M;
            decimal zo = 222.00M;
            decimal ddfl = 222.00M;
            decimal netSalary = 222.00M;
            string currentDate = "2023 01 01";

            EmployeeSalaryInfoDto expected = new EmployeeSalaryInfoDto()
            {
                BaseSalary = baseSalary,
                InternshipValue = internshipValue,
                MonthBonus = monthBonus,
                DOO = doo,
                DZPO = dzpo,
                ZO = zo,
                DDFL = ddfl,
                NetSalary = netSalary,
                Month = currentDate
            };
            string expectedObject = JsonConvert.SerializeObject(expected);

            //Act
            var actual = _employeeFactory.CreateEmployeeSalaryInfoDto(baseSalary,internshipValue, monthBonus, doo, dzpo, zo, ddfl, netSalary, currentDate);
            string actualObject = JsonConvert.SerializeObject(actual);

            //Assert
            Assert.AreEqual(expectedObject, actualObject);
        }
    }
}
