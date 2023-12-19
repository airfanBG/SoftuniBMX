namespace BicycleApp.Data.SeedData
{
    using System;
    using System.Collections.Generic;

    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Data.Models.IdentityModels;

    using Microsoft.AspNetCore.Identity;

    public class SeedClass
    {
        public ICollection<IdentityRole> SeedRoles()
        {
            return new List<IdentityRole>
            {
                new IdentityRole(){ Id = "6ac1cb3c-2457-4aff-8fa2-c7052ebcea9e", Name = "user", NormalizedName = "user".ToUpper()},
                new IdentityRole(){ Id = "f0d2cbfa-cdca-4936-9d85-f9a697d39f2b", Name = "manager", NormalizedName = "manager".ToUpper()},
                new IdentityRole(){ Id = "fa8f997a-4e15-475f-a028-87a9b6e6be56", Name = "frameworker", NormalizedName = "frameworker".ToUpper()},
                new IdentityRole(){ Id = "a9618213-7ba0-48cf-81d4-00cd16910ec7", Name = "wheelworker", NormalizedName = "wheelworker".ToUpper()},
                new IdentityRole(){ Id = "566110d3-06fe-4ca2-b34b-9334a842c88f", Name = "accessoriesworker", NormalizedName = "accessoriesworker".ToUpper()},
                new IdentityRole(){ Id = "ac558b05-a97b-42c8-bd62-dbd33f36d795", Name = "qualitycontrol", NormalizedName = "qualitycontrol".ToUpper()}
              
            };
        }

        public ICollection<IdentityUserRole<string>> SeedRolesUsers()
        {
            return new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>(){RoleId = "6ac1cb3c-2457-4aff-8fa2-c7052ebcea9e", UserId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd"},
                new IdentityUserRole<string>(){RoleId = "6ac1cb3c-2457-4aff-8fa2-c7052ebcea9e", UserId = "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f"},
                new IdentityUserRole<string>(){RoleId = "6ac1cb3c-2457-4aff-8fa2-c7052ebcea9e", UserId = "99d3ca6f-2067-4316-a5d7-934c93789521"},
                new IdentityUserRole<string>(){RoleId = "f0d2cbfa-cdca-4936-9d85-f9a697d39f2b", UserId = "406e8cf1-acaa-44a8-afec-585ff64bed34"},
                new IdentityUserRole<string>(){RoleId = "fa8f997a-4e15-475f-a028-87a9b6e6be56", UserId = "21003785-a275-4139-ae20-af6a6cf8fea8"},
                new IdentityUserRole<string>(){RoleId = "a9618213-7ba0-48cf-81d4-00cd16910ec7", UserId = "17063948-8fdc-417e-8fb7-2ae6bf572f94"},
                new IdentityUserRole<string>(){RoleId = "566110d3-06fe-4ca2-b34b-9334a842c88f", UserId = "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91"},
                new IdentityUserRole<string>(){RoleId = "ac558b05-a97b-42c8-bd62-dbd33f36d795", UserId = "29f06920-d2ad-43d8-b362-e2b94d7a7502"},
            };
        }
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
                DateDeleted = null,
                EmailConfirmed = true
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
                DateDeleted = null,
                EmailConfirmed = true
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
                DateDeleted = null,
                EmailConfirmed = true
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
                IsManeger = true,
                EmailConfirmed = true
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
                IsManeger = false,
                EmailConfirmed = true
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
                IsManeger = false,
                EmailConfirmed = true
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
                IsManeger = false,
                EmailConfirmed = true
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
                IsManeger = false,
                EmailConfirmed = true
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
            Delivary delivary1 = new Delivary()
            {
                Id = 1,
                PartId = 1,
                QuantityDelivered = 2,
                Note = "text",
                DateDelivered = DateTime.Now,
                DateUpdated = DateTime.Now,
                SuplierId = 1
            };
            Delivary delivary2 = new Delivary()
            {
                Id = 2,
                PartId = 4,
                QuantityDelivered = 2,
                Note = "text2",
                DateDelivered = DateTime.Now,
                DateUpdated = DateTime.Now,
                SuplierId = 2
            };
            Delivary delivary3 = new Delivary()
            {
                Id = 3,
                PartId = 7,
                QuantityDelivered = 1,
                Note = "text2",
                DateDelivered = DateTime.Now,
                DateUpdated = DateTime.Now,
                SuplierId = 3
            };
            Delivary delivary4 = new Delivary()
            {
                Id = 4,
                PartId = 1,
                QuantityDelivered = 4,
                Note = "text4",
                DateDelivered = DateTime.Now,
                DateUpdated = DateTime.Now,
                SuplierId = 1
            };
            Delivary delivary5 = new Delivary()
            {
                Id = 5,
                PartId = 4,
                QuantityDelivered = 4,
                Note = "text5",
                DateDelivered = DateTime.Now,
                DateUpdated = DateTime.Now,
                SuplierId = 2
            };
            Delivary delivary6 = new Delivary()
            {
                Id = 6,
                PartId = 7,
                QuantityDelivered = 2,
                Note = "text6",
                DateDelivered = DateTime.Now,
                DateUpdated = DateTime.Now,
                SuplierId = 3
            };
            Delivary delivary7 = new Delivary()
            {
                Id = 7,
                PartId = 1,
                QuantityDelivered = 3,
                Note = "text7",
                DateDelivered = DateTime.Now,
                DateUpdated = DateTime.Now,
                SuplierId = 1
            };
            Delivary delivary8 = new Delivary()
            {
                Id = 8,
                PartId = 4,
                QuantityDelivered = 5,
                Note = "text8",
                DateDelivered = DateTime.Now,
                DateUpdated = DateTime.Now,
                SuplierId = 2
            };
            Delivary delivary9 = new Delivary()
            {
                Id = 9,
                PartId = 7,
                QuantityDelivered = 4,
                Note = "text9",
                DateDelivered = DateTime.Now,
                DateUpdated = DateTime.Now,
                SuplierId = 3
            };

            return new List<Delivary> { delivary1, delivary2, delivary3, delivary4, delivary5, delivary6, delivary7, delivary8, delivary9 };
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
            Order order2 = new Order()
            {
                Id = 2,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "test2",
                SaleAmount = 725.00M,
                Discount = 0,
                VAT = 125.00M,
                FinalAmount = 850.00M,
                PaidAmount = 0,
                UnpaidAmount = 850.00M,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false,
                DateFinish = null,
                StatusId = 1
            };
            Order order3 = new Order()
            {
                Id = 3,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "test3",
                SaleAmount = 825.00M,
                Discount = 0,
                VAT = 125.00M,
                FinalAmount = 950.00M,
                PaidAmount = 0,
                UnpaidAmount = 750.00M,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false,
                DateFinish = null,
                StatusId = 1
            };
            Order order4 = new Order()
            {
                Id = 4,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "test4",
                SaleAmount = 525.00M,
                Discount = 0,
                VAT = 125.00M,
                FinalAmount = 650.00M,
                PaidAmount = 0,
                UnpaidAmount = 750.00M,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false,
                DateFinish = null,
                StatusId = 1
            };
            Order order5 = new Order()
            {
                Id = 5,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "test5",
                SaleAmount = 725.00M,
                Discount = 0,
                VAT = 125.00M,
                FinalAmount = 850.00M,
                PaidAmount = 0,
                UnpaidAmount = 850.00M,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false,
                DateFinish = null,
                StatusId = 1
            };
            Order order6 = new Order()
            {
                Id = 6,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "test6",
                SaleAmount = 525.00M,
                Discount = 0,
                VAT = 125.00M,
                FinalAmount = 850.00M,
                PaidAmount = 0,
                UnpaidAmount = 650.00M,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false,
                DateFinish = null,
                StatusId = 1
            };
            Order order7 = new Order()
            {
                Id = 7,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "test7",
                SaleAmount = 525.00M,
                Discount = 0,
                VAT = 125.00M,
                FinalAmount = 650.00M,
                PaidAmount = 0,
                UnpaidAmount = 750.00M,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false,
                DateFinish = null,
                StatusId = 1
            };
            Order order8 = new Order()
            {
                Id = 8,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "test8",
                SaleAmount = 725.00M,
                Discount = 0,
                VAT = 125.00M,
                FinalAmount = 850.00M,
                PaidAmount = 0,
                UnpaidAmount = 850.00M,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false,
                DateFinish = null,
                StatusId = 1
            };
            Order order9 = new Order()
            {
                Id = 9,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "test9",
                SaleAmount = 525.00M,
                Discount = 0,
                VAT = 125.00M,
                FinalAmount = 850.00M,
                PaidAmount = 0,
                UnpaidAmount = 650.00M,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false,
                DateFinish = null,
                StatusId = 1
            };
            Order order10 = new Order()
            {
                Id = 10,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "Passed quality control",
                SaleAmount = 354.17M,
                Discount = 0,
                VAT = 70.83M,
                FinalAmount = 425.00M,
                PaidAmount = 0,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false,
                DateFinish = null,
                StatusId = 1
            };

            return new List<Order> { order, order2, order3, order4, order5, order6, order7, order8, order9, order10 };
        }

        public List<OrderPartEmployee> SeedOrdersPartsEmployees()
        {
            OrderPartEmployee opeFrame = new OrderPartEmployee()
            {
                OrderId = 1,
                SerialNumber = "BID12345678",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
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
                SerialNumber = "BID12345678",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
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
                SerialNumber = "BID12345678",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 3,
                EmployeeId = "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                PartName = "Shift",
                PartPrice = 250.00M,
                PartQuantity = 1,
                DatetimeAsigned = DateTime.Now,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeFrame2 = new OrderPartEmployee()
            {
                OrderId = 2,
                SerialNumber = "BID12345679",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 1,
                EmployeeId = null,
                PartName = "Frame OG",
                PartPrice = 100.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeWheel2 = new OrderPartEmployee()
            {
                OrderId = 2,
                SerialNumber = "BID12345679",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 4,
                EmployeeId = null,
                PartName = "Wheel of the Year for road",
                PartPrice = 75.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeAccessories2 = new OrderPartEmployee()
            {
                OrderId = 2,
                SerialNumber = "BID12345679",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 12,
                EmployeeId = null,
                PartName = "Shift",
                PartPrice = 220.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeFrame3 = new OrderPartEmployee()
            {
                OrderId = 3,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 1,
                EmployeeId = null,
                PartName = "Frame OG",
                PartPrice = 100.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeWheel3 = new OrderPartEmployee()
            {
                OrderId = 3,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 5,
                EmployeeId = null,
                PartName = "Wheel of the Year for montain",
                PartPrice = 85.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeAccessories3 = new OrderPartEmployee()
            {
                OrderId = 3,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 11,
                EmployeeId = null,
                PartName = "Road budget Shifts",
                PartPrice = 290.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeFrame4 = new OrderPartEmployee()
            {
                OrderId = 4,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 1,
                EmployeeId = null,
                PartName = "Frame OG",
                PartPrice = 100.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeWheel4 = new OrderPartEmployee()
            {
                OrderId = 4,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 5,
                EmployeeId = null,
                PartName = "Wheel of the Year for montain",
                PartPrice = 85.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeAccessories4 = new OrderPartEmployee()
            {
                OrderId = 4,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 11,
                EmployeeId = null,
                PartName = "Road budget Shifts",
                PartPrice = 290.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeFrame5 = new OrderPartEmployee()
            {
                OrderId = 5,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 1,
                EmployeeId = null,
                PartName = "Frame OG",
                PartPrice = 100.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeWheel5 = new OrderPartEmployee()
            {
                OrderId = 5,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 5,
                EmployeeId = null,
                PartName = "Wheel of the Year for montain",
                PartPrice = 85.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeAccessories5 = new OrderPartEmployee()
            {
                OrderId = 5,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 11,
                EmployeeId = null,
                PartName = "Road budget Shifts",
                PartPrice = 290.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeFrame6 = new OrderPartEmployee()
            {
                OrderId = 6,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 1,
                EmployeeId = null,
                PartName = "Frame OG",
                PartPrice = 100.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeWheel6 = new OrderPartEmployee()
            {
                OrderId = 6,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 5,
                EmployeeId = null,
                PartName = "Wheel of the Year for montain",
                PartPrice = 85.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeAccessories6 = new OrderPartEmployee()
            {
                OrderId = 6,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 11,
                EmployeeId = null,
                PartName = "Road budget Shifts",
                PartPrice = 290.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeFrame7 = new OrderPartEmployee()
            {
                OrderId = 7,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 1,
                EmployeeId = null,
                PartName = "Frame OG",
                PartPrice = 100.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeWheel7 = new OrderPartEmployee()
            {
                OrderId = 7,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 5,
                EmployeeId = null,
                PartName = "Wheel of the Year for montain",
                PartPrice = 85.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeAccessories7 = new OrderPartEmployee()
            {
                OrderId = 7,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 11,
                EmployeeId = null,
                PartName = "Road budget Shifts",
                PartPrice = 290.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeFrame8 = new OrderPartEmployee()
            {
                OrderId = 8,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 1,
                EmployeeId = null,
                PartName = "Frame OG",
                PartPrice = 100.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeWheel8 = new OrderPartEmployee()
            {
                OrderId = 8,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 5,
                EmployeeId = null,
                PartName = "Wheel of the Year for montain",
                PartPrice = 85.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeAccessories8 = new OrderPartEmployee()
            {
                OrderId = 8,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 11,
                EmployeeId = null,
                PartName = "Road budget Shifts",
                PartPrice = 290.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeFrame9 = new OrderPartEmployee()
            {
                OrderId = 9,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 1,
                EmployeeId = null,
                PartName = "Frame OG",
                PartPrice = 100.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeWheel9 = new OrderPartEmployee()
            {
                OrderId = 9,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 5,
                EmployeeId = null,
                PartName = "Wheel of the Year for montain",
                PartPrice = 85.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee opeAccessories9 = new OrderPartEmployee()
            {
                OrderId = 9,
                SerialNumber = "BID12345680",
                UniqueKeyForSerialNumber = "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb",
                PartId = 11,
                EmployeeId = null,
                PartName = "Road budget Shifts",
                PartPrice = 290.00M,
                PartQuantity = 1,
                DatetimeAsigned = null,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };
            OrderPartEmployee qualityControlOpeFrame = new OrderPartEmployee()
            {
                OrderId = 10,
                SerialNumber = "BIDPASQC123",
                UniqueKeyForSerialNumber = "231b3632-b31c-4711-8f67-fe42b36642b5",
                PartId = 1,
                EmployeeId = "21003785-a275-4139-ae20-af6a6cf8fea8",
                PartName = "Frame OG",
                PartPrice = 100.00M,
                PartQuantity = 1,
                DatetimeAsigned = new DateTime(2023,12,16,15,48,13),
                StartDatetime = new DateTime(2023, 12, 16, 16, 48, 13),
                EndDatetime = new DateTime(2023, 12, 16, 16, 53, 13),
                Description = "test",
                IsCompleted = true
            };
            OrderPartEmployee qualityControlOpeWheel = new OrderPartEmployee()
            {
                OrderId = 10,
                SerialNumber = "BIDPASQC123",
                UniqueKeyForSerialNumber = "231b3632-b31c-4711-8f67-fe42b36642b5",
                PartId = 2,
                EmployeeId = "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                PartName = "Wheel of the YearG",
                PartPrice = 75.00M,
                PartQuantity = 1,
                DatetimeAsigned = new DateTime(2023, 12, 16, 15, 48, 13),
                StartDatetime = new DateTime(2023, 12, 17, 9, 10, 13),
                EndDatetime = new DateTime(2023, 12, 17, 9, 15, 13),
                Description = "test",
                IsCompleted = true
            };
            OrderPartEmployee qualityControlOpeAccessories = new OrderPartEmployee()
            {
                OrderId = 10,
                SerialNumber = "BIDPASQC123",
                UniqueKeyForSerialNumber = "231b3632-b31c-4711-8f67-fe42b36642b5",
                PartId = 3,
                EmployeeId = "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                PartName = "Shift",
                PartPrice = 250.00M,
                PartQuantity = 1,
                DatetimeAsigned = new DateTime(2023, 12, 16, 15, 48, 13),
                StartDatetime = new DateTime(2023, 12, 17, 10, 15, 13),
                EndDatetime = new DateTime(2023, 12, 17, 10, 30, 13),
                Description = "test",
                IsCompleted = true
            };
            return new List<OrderPartEmployee> {
                opeFrame, opeWheel, opeAccessories, opeFrame2, opeWheel2, opeAccessories2, opeFrame3, opeWheel3, opeAccessories3,
                opeFrame4, opeWheel4, opeAccessories4, opeFrame5, opeWheel5, opeAccessories5, opeFrame6, opeWheel6, opeAccessories6,
                opeFrame7, opeWheel7, opeAccessories7, opeFrame8, opeWheel8, opeAccessories8, opeFrame9, opeWheel9, opeAccessories9,qualityControlOpeFrame,qualityControlOpeWheel,qualityControlOpeAccessories
            };
        }
        public ICollection<OrderPartEmployeeInfo> SeedOrderOrderParsEmployeeInfos()
        {
            return new List<OrderPartEmployeeInfo>() 
            { 
                new OrderPartEmployeeInfo()
                {
                    Id = 1,
                    OrderId = 10,
                    PartId = 1,
                    UniqueKeyForSerialNumber = "231b3632-b31c-4711-8f67-fe42b36642b5",
                    ProductionТime = new TimeSpan(0,5,0)
                },
                new OrderPartEmployeeInfo()
                {
                    Id = 2,
                    OrderId = 10,
                    PartId = 2,
                    UniqueKeyForSerialNumber = "231b3632-b31c-4711-8f67-fe42b36642b5",
                    ProductionТime = new TimeSpan(0,5,0)
                },
                new OrderPartEmployeeInfo()
                {
                    Id = 3,
                    OrderId = 10,
                    PartId = 3,
                    UniqueKeyForSerialNumber = "231b3632-b31c-4711-8f67-fe42b36642b5",
                    ProductionТime = new TimeSpan(0,15,0)
                },
            };
        }

        public List<Part> SeedParts()
        {
            return new List<Part> {
                 new Part()
                 {
                    Id = 1,
                    Name = "Frame Road",
                    Description = "Best frame in the road!",
                    Intend = "For road usage",
                    OEMNumber = "oemtest1",
                    Type = 1,
                    CategoryId = 1,
                    Quantity = 32,
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
                    Intend = "For montain usage",
                    OEMNumber = "oemtest2",
                    Type = 2,
                    CategoryId = 1,
                    Quantity = 43,
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
                    Intend = "For road usage in women bikes",
                    OEMNumber = "oemtest3",
                    Type = 3,
                    CategoryId = 1,
                    Quantity = 32,
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
                    Intend = "Best wheels for a road usage",
                    OEMNumber = "oemtest4",
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
                    Intend = "Best wheels for a montain usage",
                    OEMNumber = "oemtest5",
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
                    Intend = "Best seler for a road usage",
                    OEMNumber = "oemtest6",
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
                    Intend = "Base shift - have only one",
                    OEMNumber = "oemtest7",
                    CategoryId = 3,
                    Type = 1,
                    Quantity = 29,
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
                    Intend = "Best shift for a montain usage",
                    OEMNumber = "oemtest8",
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
                    Intend = "Best shift for a road usage",
                    OEMNumber = "oemtest9",
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
                    Intend = "Better shift for a road usage",
                    OEMNumber = "oemtest10",
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
                    Intend = "Budget shift for a road usage",
                    OEMNumber = "oemtest11",
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
                    Intend = "Cheap standard shift for a road usage",
                    OEMNumber = "oemtest12",
                    CategoryId = 3,
                    Type = 1,
                    Quantity = 29,
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
                    Intend = "Budget shift for a montain usage",
                    OEMNumber = "oemtest13",
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
                    Description = "Budget wheel ever!",
                    Intend = "Budget wheel for a road usage",
                    OEMNumber = "oemtest14",
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
                    Intend = "Budget wheel for a montain usage",
                    OEMNumber = "oemtest15",
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
                    Intend = "The cheapest wheel for a road usage",
                    OEMNumber = "oemtest16",
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
                    Description = "The best titanium wheel for a road!",
                    Intend = "The best titanium wheel for a road usage",
                    OEMNumber = "oemtest17",
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
                    Name = "Acsessories",
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
            return new List<Rate>
            {
                new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 1,
                    Rating = 5
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 1,
                    Rating = 4
                },
                new Rate()
                {
                    ClientId = "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                    PartId = 1,
                    Rating = 3
                },
                new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 2,
                    Rating = 5
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 2,
                    Rating = 4
                },
                 new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 3,
                    Rating = 6
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 3,
                    Rating = 4
                },
                new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 4,
                    Rating = 4
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 4,
                    Rating = 3
                },
                new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 5,
                    Rating = 3
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 5,
                    Rating = 6
                },
                 new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 6,
                    Rating = 6
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 6,
                    Rating = 6
                },
                new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 7,
                    Rating = 6
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 7,
                    Rating = 5
                },
                new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 8,
                    Rating = 5
                },
                new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 9,
                    Rating = 5
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 9,
                    Rating = 5
                },
                new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 10,
                    Rating = 5
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 10,
                    Rating = 5
                },
                new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 11,
                    Rating = 5
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 11,
                    Rating = 3
                },
                                new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 12,
                    Rating = 5
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 12,
                    Rating = 4
                },
                new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 13,
                    Rating = 4
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 13,
                    Rating = 5
                },
                new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 14,
                    Rating = 3
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 14,
                    Rating = 5
                },
                new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 15,
                    Rating = 4
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 15,
                    Rating = 4
                },
                new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 16,
                    Rating = 3
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 16,
                    Rating = 5
                },
                new Rate()
                {
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    PartId = 17,
                    Rating = 3
                },
                new Rate()
                {
                    ClientId = "99d3ca6f-2067-4316-a5d7-934c93789521",
                    PartId = 17,
                    Rating = 2
                },
            };
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
            Suplier suplier1 = new Suplier()
            {
                Id = 1,
                Name = "X Ltd",
                VATNumber = "123456789",
                Address = "Sofia, center",
                PhoneNumeber = "1234567890",
                Email = "text@test.bg",
                ContactName = "Pesh Peshev",
                CategoryName = "Frame",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            };
            Suplier suplier2 = new Suplier()
            {
                Id = 2,
                Name = "XX Ltd",
                VATNumber = "123456788",
                Address = "Sofia, east",
                PhoneNumeber = "1234567899",
                Email = "text2@test.bg",
                ContactName = "Pesho Peshev",
                CategoryName = "Wheel",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            };
            Suplier suplier3 = new Suplier()
            {
                Id = 3,
                Name = "XXX Ltd",
                VATNumber = "123456787",
                Address = "Sofia, west",
                PhoneNumeber = "1234567897",
                Email = "text3@test.bg",
                ContactName = "Ivan Peshev",
                CategoryName = "Acsessories",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            };

            return new List<Suplier> { suplier1, suplier2, suplier3 };
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
        public List<PartInStock> SeedPartsInStock()
        {
            PartInStock partInStock1 = new PartInStock()
            {
                Id = 1,
                OemPartNumber = "oemtest1",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            };
            PartInStock partInStock2 = new PartInStock()
            {
                Id = 2,
                OemPartNumber = "oemtest2",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            }; PartInStock partInStock3 = new PartInStock()
            {
                Id = 3,
                OemPartNumber = "oemtest3",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            }; PartInStock partInStock4 = new PartInStock()
            {
                Id = 4,
                OemPartNumber = "oemtest4",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            }; PartInStock partInStock5 = new PartInStock()
            {
                Id = 5,
                OemPartNumber = "oemtest5",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            }; PartInStock partInStock6 = new PartInStock()
            {
                Id = 6,
                OemPartNumber = "oemtest6",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            }; PartInStock partInStock7 = new PartInStock()
            {
                Id = 7,
                OemPartNumber = "oemtest7",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            }; PartInStock partInStock8 = new PartInStock()
            {
                Id = 8,
                OemPartNumber = "oemtest8",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            }; PartInStock partInStock9 = new PartInStock()
            {
                Id = 9,
                OemPartNumber = "oemtest9",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            }; PartInStock partInStock10 = new PartInStock()
            {
                Id = 10,
                OemPartNumber = "oemtest10",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            }; PartInStock partInStock11 = new PartInStock()
            {
                Id = 11,
                OemPartNumber = "oemtest11",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            }; PartInStock partInStock12 = new PartInStock()
            {
                Id = 12,
                OemPartNumber = "oemtest12",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            }; PartInStock partInStock13 = new PartInStock()
            {
                Id = 13,
                OemPartNumber = "oemtest13",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            };
            return new List<PartInStock> { partInStock1,
                partInStock2,
                partInStock3,
                partInStock4,
                partInStock5,
                partInStock6,
                partInStock7,
                partInStock8,
                partInStock9,
                partInStock10,
                partInStock11,
                partInStock12,
                partInStock13,
            };
        }
        public List<PartOrder> SeedPartOrders()
        {
            PartOrder partOrder1 = new PartOrder()
            {
                Id = 1,
                PartId = 1,
                Quantity = 2,
                Note = "text",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                SuplierId = 1
            };
            PartOrder partOrder2 = new PartOrder()
            {
                Id = 2,
                PartId = 4,
                Quantity = 2,
                Note = "text2",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                SuplierId = 2
            };
            PartOrder partOrder3 = new PartOrder()
            {
                Id = 3,
                PartId = 7,
                Quantity = 1,
                Note = "text2",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                SuplierId = 3
            };

            return new List<PartOrder> { partOrder1, partOrder2, partOrder3 };
        }
        public ICollection<BikeStandartModel> SeedBikeStandartModels()
        {
            return new List<BikeStandartModel>
            {
                new BikeStandartModel()
                {
                    Id = 1,
                    ModelName = "Bike 1",
                    ImageUrl = "https://yuchormanski.free.bg/bikes/bike-1.webp",
                    Price = 575M,
                    Description = "Slow Initial Rendering: Since the data is fetched from the server before rendering, initial load times can be slow, resulting in a less-than-ideal user experience."
                },
                 new BikeStandartModel()
                {
                    Id = 2,
                    ModelName = "Bike 2",
                    ImageUrl = "https://yuchormanski.free.bg/bikes/bike-2.webp",
                    Price = 365M,
                    Description = "Loading States: Users may experience an in-between or loading state, as they wait for the data to be rendered on the page."
                },
                 new BikeStandartModel()
                {
                    Id = 3,
                    ModelName = "Bike 3",
                    ImageUrl = "https://yuchormanski.free.bg/bikes/bike-3.webp",
                    Price = 455M,
                    Description = "Lack of Interactivity: There isn’t much opportunity for interactivity with the user until the data has been fully loaded and rendered on the page."
                },
            };
        }
        public ICollection<BikeModelPart> SeedBikeModelPartls()
        {
            return new List<BikeModelPart>
            {
                new BikeModelPart()
                {
                    BikeModelId = 1,
                    PartId = 1
                },
                new BikeModelPart()
                {
                    BikeModelId = 1,
                    PartId = 4
                },
                new BikeModelPart()
                {
                    BikeModelId = 1,
                    PartId = 9
                },
                new BikeModelPart()
                {
                    BikeModelId = 2,
                    PartId = 3
                },
                new BikeModelPart()
                {
                    BikeModelId = 2,
                    PartId = 14
                },
                 new BikeModelPart()
                {
                    BikeModelId = 2,
                    PartId = 12
                },
                 new BikeModelPart()
                {
                    BikeModelId = 3,
                    PartId = 2
                },
                  new BikeModelPart()
                {
                    BikeModelId = 3,
                    PartId = 5
                },
                  new BikeModelPart()
                {
                    BikeModelId = 3,
                    PartId = 13
                }
            };
        }
    }
}