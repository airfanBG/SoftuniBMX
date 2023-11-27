namespace BicycleApp.Data.SeedData
{
    using System;
    using System.Collections.Generic;

    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Data.Models.IdentityModels;

    using Microsoft.AspNetCore.Identity;

    public class SeedClass
    {
        public List<Client> SeedClients()
        {
            var hasher = new PasswordHasher<Client>();
            string pass = "123456";

            Client client = new Client
            {
                Id = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Email = "client@test.bg",
                UserName = "client@test.bg",
                NormalizedEmail = "client@test.bg".ToUpper(),
                SecurityStamp = "client@test.bg".ToUpper(),
                FirstName = "Ivan",
                LastName = "Ivanov",
                PhoneNumber = "1234567890",
                DelivaryAddress = "Mladost 1, bl 20",
                TownId = 1,
                IBAN = "BG0012345678910111212",
                Balance = 1000.00M,
                IsDeleted = false,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateDeleted = null
            };

            client.PasswordHash = hasher.HashPassword(client, pass);

            Client client2 = new Client
            {
                Id = "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                Email = "joro@test.bg",
                UserName = "joro@test.bg",
                NormalizedEmail = "joro@test.bg".ToUpper(),
                SecurityStamp = "joro@test.bg".ToUpper(),
                FirstName = "Georgi",
                LastName = "Georgiev",
                PhoneNumber = "1234567890",
                DelivaryAddress = "Mladost 1, bl 20",
                TownId = 2,
                IBAN = "BG0012345678910111212",
                Balance = 50.00M,
                IsDeleted = false,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateDeleted = null
            };

            client2.PasswordHash = hasher.HashPassword(client2, pass);

            Client client3 = new Client
            {
                Id = "99d3ca6f-2067-4316-a5d7-934c93789521",
                Email = "powerranger@test.bg",
                UserName = "powerranger@test.bg",
                NormalizedEmail = "powerranger@test.bg".ToUpper(),
                SecurityStamp = "powerranger@test.bg".ToUpper(),
                FirstName = "Dimityr",
                LastName = "Dimitrov",
                PhoneNumber = "1234567890",
                DelivaryAddress = "Mladost 1, bl 20",
                TownId = 3,
                IBAN = "BG0012345678910111212",
                Balance = 1246.00M,
                IsDeleted = false,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateDeleted = null
            };

            client3.PasswordHash = hasher.HashPassword(client3, pass);

            var list = new List<Client>
            {
                client,
                client2,
                client3
            };
            return list;
        }

        public List<Employee> SeedEmployees()
        {
            var employees = new List<Employee>();

            var hasher = new PasswordHasher<Employee>();
            string pass = "User123!";

            Employee manager = new Employee()
            {
                Id = "406e8cf1-acaa-44a8-afec-585ff64bed34",
                Email = "manager@b-free.com",
                UserName = "manager@b-free.com",
                NormalizedEmail = "manager@b-free.com".ToUpper(),
                SecurityStamp = "manager@b-free.com".ToUpper(),
                FirstName = "Kalin",
                LastName = "Kalinov",
                PhoneNumber = "1234567890",
                Position = "manager",
                DateOfHire = DateTime.Now,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateOfLeave = null,
                IsDeleted = false,
                DepartmentId = 1,
                IsManeger = true
            };
            manager.PasswordHash = hasher.HashPassword(manager, pass);

            employees.Add(manager);

            Employee employee = new Employee()
            {
                Id = "21003785-a275-4139-ae20-af6a6cf8fea8",
                Email = "marinov@b-free.com",
                UserName = "marinov@b-free.com",
                NormalizedEmail = "marinov@b-free.com".ToUpper(),
                SecurityStamp = "marinov@b-free.com".ToUpper(),
                FirstName = "Marin",
                LastName = "Marinov",
                PhoneNumber = "1234567890",
                Position = "FrameWorker",
                DateOfHire = DateTime.Now,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateOfLeave = null,
                IsDeleted = false,
                DepartmentId = 2,
                IsManeger = false
            };
            employee.PasswordHash = hasher.HashPassword(employee, pass);

            employees.Add(employee);

            Employee worker2 = new Employee()
            {
                Id = "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                Email = "todorov@b-free.com",
                UserName = "todorov@b-free.com",
                NormalizedEmail = "todorov@b-free.com".ToUpper(),
                SecurityStamp = "todorov@b-free.com".ToUpper(),
                FirstName = "Todor",
                LastName = "Todorov",
                PhoneNumber = "1234567890",
                Position = "Wheelworker",
                DateOfHire = DateTime.Now,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateOfLeave = null,
                IsDeleted = false,
                DepartmentId = 2,
                IsManeger = false
            };
            worker2.PasswordHash = hasher.HashPassword(worker2, pass);

            employees.Add(worker2);

            Employee worker3 = new Employee()
            {
                Id = "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                Email = "ivanov@b-free.com",
                UserName = "ivanov@b-free.com",
                NormalizedEmail = "ivanov@b-free.com".ToUpper(),
                SecurityStamp = "ivanov@b-free.com".ToUpper(),
                FirstName = "Ivan",
                LastName = "Ivanov",
                PhoneNumber = "1234567890",
                Position = "Accessoriesworker",
                DateOfHire = DateTime.Now,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateOfLeave = null,
                IsDeleted = false,
                DepartmentId = 2,
                IsManeger = false
            };
            worker3.PasswordHash = hasher.HashPassword(worker3, pass);

            employees.Add(worker3);

            Employee worker4 = new Employee()
            {
                Id = "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                Email = "atanasov@b-free.com",
                UserName = "atanasov@b-free.com",
                NormalizedEmail = "atanasov@b-free.com".ToUpper(),
                SecurityStamp = "atanasov@b-free.com".ToUpper(),
                FirstName = "Atanas",
                LastName = "Atanasov",
                PhoneNumber = "1234567890",
                Position = "Qualitycontrol",
                DateOfHire = DateTime.Now,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateOfLeave = null,
                IsDeleted = false,
                DepartmentId = 2,
                IsManeger = false
            };
            worker4.PasswordHash = hasher.HashPassword(worker4, pass);

            employees.Add(worker4);

            return employees;
        }

        public List<Comment> SeedComments()
        {
            Comment comment = new Comment()
            {
                Id = 1,
                PartId = 1,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Title = "Test Title",
                Description = "Test Description",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            return new List<Comment> { comment };
        }

        public List<Delivary> SeedDelivaries()
        {
            Delivary delivary = new Delivary()
            {
                Id = 1,
                PartId = 1,
                QuantityDelivered = 2,
                Note = "text",
                DateDelivered = DateTime.Now,
                DateUpdated = DateTime.Now,
                SuplierId = 1
            };

            return new List<Delivary> { delivary };
        }

        public List<Department> SeedDepartments()
        {
            return new List<Department> {
                new Department()
                    {
                        Id = 1,
                        Name = "Administration",
                        DateCreated = DateTime.Now,
                        DateUpdated = null,
                        DateDeleted = null,
                        IsDeleted = false
                    },
                new Department()
                    {
                        Id = 2,
                        Name = "Workshop",
                        DateCreated = DateTime.Now,
                        DateUpdated = null,
                        DateDeleted = null,
                        IsDeleted = false
                    }
            };
        }

        public List<ImagePart> SeedImagesParts()
        {
            ImagePart imagePart = new ImagePart()
            {
                Id = 1,
                ImageName = "image",
                ImageUrl = "test",
                PartId = 1
            };

            return new List<ImagePart> { imagePart };
        }

        public List<ImageClient> SeedImagesClients()
        {
            ImageClient imageClient = new ImageClient()
            {
                Id = 1,
                ImageName = "image",
                ImageUrl = "test",
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd"
            };

            return new List<ImageClient> { imageClient };
        }

        public List<ImageEmployee> SeedImagesEmployees()
        {
            ImageEmployee imageEmployee = new ImageEmployee()
            {
                Id = 1,
                ImageName = "image",
                ImageUrl = "test",
                EmployeeId = "21003785-a275-4139-ae20-af6a6cf8fea8"
            };

            return new List<ImageEmployee> { imageEmployee };
        }

        public List<Order> SeedOrders()
        {
            Order order = new Order()
            {
                Id = 1,
                SerialNumber = "BID12345678",
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "",
                SaleAmount = 625.00M,
                Discount = 0,
                VAT = 125.00M,
                FinalAmount = 750.00M,
                PaidAmount = 0,
                UnpaidAmount = 750.00M,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false,
                DateFinish = null,
                StatusId = 1
            };

            return new List<Order> { order };
        }

        public List<OrderPartEmployee> SeedOrdersPartsEmployees()
        {
            OrderPartEmployee opeFrame = new OrderPartEmployee()
            {
                OrderId = 1,
                PartId = 1,
                EmployeeId = "21003785-a275-4139-ae20-af6a6cf8fea8",
                PartName = "Frame OG",
                PartPrice = 100.00M,
                PartQuantity = 1,
                DatetimeAsigned = DateTime.Now,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeWheel = new OrderPartEmployee()
            {
                OrderId = 1,
                PartId = 2,
                EmployeeId = "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                PartName = "Wheel of the YearG",
                PartPrice = 75.00M,
                PartQuantity = 2,
                DatetimeAsigned = DateTime.Now,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeAccessories = new OrderPartEmployee()
            {
                OrderId = 1,
                PartId = 3,
                EmployeeId = "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                PartName = "Shift",
                PartPrice = 250.00M,
                PartQuantity = 2,
                DatetimeAsigned = DateTime.Now,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            return new List<OrderPartEmployee> {
                opeFrame };
        }

        public List<Part> SeedParts()
        {
            return new List<Part> {
                 new Part()
                 {
                    Id = 1,
                    Name = "Frame Road",
                    Description = "Best frame in the road!",
                    OEMNumber = "oemtest",
                    Type = 1,
                    CategoryId = 1,
                    Quantity = 2,
                    SalePrice = 100.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                 new Part()
                 {
                    Id = 2,
                    Name = "Frame Montain",
                    Description = "Best frame in the montain",
                    OEMNumber = "oemtest2",
                    Type = 2,
                    CategoryId = 1,
                    Quantity = 4,
                    SalePrice = 90.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                 new Part()
                 {
                    Id = 3,
                    Name = "Frame Road woman",
                    Description = "Best frame in the road for womens",
                    OEMNumber = "oemtest2",
                    Type = 3,
                    CategoryId = 1,
                    Quantity = 3,
                    SalePrice = 80.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                 new Part()
                 {
                    Id = 4,
                    Name = "Wheel of the Year for road",
                    Description = "Best wheels ever!",
                    OEMNumber = "oemtest",
                    Type = 1,
                    CategoryId = 2,
                    Quantity = 50,
                    SalePrice = 75.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                 new Part()
                 {
                    Id = 5,
                    Name = "Wheel of the Year for montain",
                    Description = "Best wheels for a montain!",
                    OEMNumber = "oemtest",
                    Type = 2,
                    CategoryId = 2,
                    Quantity = 40,
                    SalePrice = 85.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                 new Part()
                 {
                    Id = 6,
                    Name = "Road wheel best seler",
                    Description = "Best wheels for a road!",
                    OEMNumber = "oemtest",
                    Type = 3,
                    CategoryId = 2,
                    Quantity = 50,
                    SalePrice = 65.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                 new Part()
                 {
                    Id = 7,
                    Name = "Shift",
                    Description = "Worst shift - have only one!",
                    OEMNumber = "oemtest",
                    CategoryId = 3,
                    Type = 1,
                    Quantity = 9,
                    SalePrice = 250.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                 new Part()
                 {
                    Id = 8,
                    Name = "Montain Shifts",
                    Description = "Best shifts for a montain!",
                    OEMNumber = "oemtest",
                    CategoryId = 3,
                    Type = 2,
                    Quantity = 19,
                    SalePrice = 350.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                 new Part()
                 {
                    Id = 9,
                    Name = "Road Shifts",
                    Description = "Best shifts for a road!",
                    OEMNumber = "oemtest",
                    CategoryId = 3,
                    Type = 3,
                    Quantity = 29,
                    SalePrice = 400.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                 new Part()
                 {
                    Id = 10,
                    Name = "Road better Shifts",
                    Description = "Better shifts for a road!",
                    OEMNumber = "oemtest9",
                    CategoryId = 3,
                    Type = 3,
                    Quantity = 21,
                    SalePrice = 410.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                  new Part()
                 {
                    Id = 11,
                    Name = "Road budget Shifts",
                    Description = "Budget shifts for a road!",
                    OEMNumber = "oemtest91",
                    CategoryId = 3,
                    Type = 3,
                    Quantity = 21,
                    SalePrice = 290.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                 new Part()
                 {
                    Id = 12,
                    Name = "Shift",
                    Description = "Cheap standard shift!",
                    OEMNumber = "oemtest21",
                    CategoryId = 3,
                    Type = 1,
                    Quantity = 9,
                    SalePrice = 220.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                 new Part()
                 {
                    Id = 13,
                    Name = "Montain Shifts",
                    Description = "Budget shifts for a montain!",
                    OEMNumber = "oemtest98",
                    CategoryId = 3,
                    Type = 2,
                    Quantity = 19,
                    SalePrice = 280.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                 new Part()
                 {
                    Id = 14,
                    Name = "Budget wheel for road",
                    Description = "Budget wheels ever!",
                    OEMNumber = "oemtest34",
                    Type = 1,
                    CategoryId = 2,
                    Quantity = 50,
                    SalePrice = 65.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                 new Part()
                 {
                    Id = 15,
                    Name = "Budget wheel for a montain",
                    Description = "Budget wheel for a montain!",
                    OEMNumber = "oemtest56",
                    Type = 2,
                    CategoryId = 2,
                    Quantity = 40,
                    SalePrice = 75.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                 new Part()
                 {
                    Id = 16,
                    Name = "The cheapest road wheel",
                    Description = "The cheapest wheel for a road!",
                    OEMNumber = "oemtest",
                    Type = 3,
                    CategoryId = 2,
                    Quantity = 50,
                    SalePrice = 55.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
                 new Part()
                 {
                    Id = 17,
                    Name = "Road titanium wheel",
                    Description = "The best  titanium wheel for a road!",
                    OEMNumber = "oemtest567",
                    Type = 3,
                    CategoryId = 2,
                    Quantity = 50,
                    SalePrice = 95.00M,
                    VATCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                 },
            };
        }

        public List<PartCategory> SeedPartCategories()
        {
            return new List<PartCategory>()
            {
                new PartCategory()
                {
                    Id = 1,
                    Name = "Frame",
                    ImageUrl = "test",
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                },
                new PartCategory()
                {
                    Id = 2,
                    Name = "Wheel",
                    ImageUrl = "test",
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                },
                new PartCategory()
                {
                    Id = 3,
                    Name = "Shift",
                    ImageUrl = "test",
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                }
            };

        }

        public List<Rate> SeedRates()
        {
            Rate rate = new Rate()
            {
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                PartId = 1,
                Rating = 5
            };

            return new List<Rate> { rate };
        }

        public List<Status> SeedStatuses()
        {
            return new List<Status>
            {
                new Status()
                {
                    Id = 1,
                    Name = "Pending approval",
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                },
                new Status()
                {
                    Id = 2,
                    Name = "Approved order",
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                },
                new Status()
                {
                    Id = 3,
                    Name = "Frame management",
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                },
                new Status()
                {
                    Id = 4,
                    Name = "Wheel management",
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                },
                new Status()
                {
                    Id = 5,
                    Name = "Shift management",
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                },
                new Status()
                {
                    Id = 6,
                    Name = "Quality control",
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                },
                new Status()
                {
                    Id = 7,
                    Name = "Send order",
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                }
             };
        }

        public List<Suplier> SeedSuplieres()
        {
            Suplier suplier = new Suplier()
            {
                Id = 1,
                Name = "X Ltd",
                VATNumber = "123456789",
                Address = "Sofia, center",
                PhoneNumeber = "1234567890",
                Email = "text@test.bg",
                ContactName = "Pesh Peshev",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            };

            return new List<Suplier> { suplier };
        }

        public List<Town> SeedTowns()
        {
            return new List<Town> {
                new Town()
                    {
                        Id = 1,
                        Name = "Sofia",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        DateDeleted = null,
                        IsDeleted = false
                    },
                new Town()
                {
                    Id = 2,
                        Name = "Varna",
                        DateCreated = DateTime.Now,
                        DateUpdated =null,
                        DateDeleted = null,
                        IsDeleted = false
                },
                new Town()
                {
                    Id = 3,
                        Name = "Burgas",
                        DateCreated = DateTime.Now,
                        DateUpdated =null,
                        DateDeleted = null,
                        IsDeleted = false
                }
            };
        }

        public List<VATCategory> SeedVATCategories()
        {
            VATCategory category = new VATCategory()
            {
                Id = 1,
                VATPercent = 20.00M,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            };

            return new List<VATCategory> { category };
        }
    }
}