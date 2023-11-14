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
                DelivaryAddress = "Sofia, Mladost 1, bl 20",
                TownId = 1,
                IBAN = "BG0012345678910111212",
                Balance = 1000.00M,
                IsDeleted = false,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateDeleted = null
            };

            var hasher = new PasswordHasher<Client>();
            string pass = "123456";
            client.PasswordHash = hasher.HashPassword(client, pass);

            return new List<Client> { client };
        }

        public List<Employee> SeedEmployees()
        {
            var employees = new List<Employee>();

            Employee employee = new Employee()
            {
                Id = "21003785-a275-4139-ae20-af6a6cf8fea8",
                Email = "employee@test.bg",
                UserName = "employee@test.bg",
                NormalizedEmail = "employee@test.bg".ToUpper(),
                SecurityStamp = "employee@test.bg".ToUpper(),
                FirstName = "Marin",
                LastName = "Marinov",
                PhoneNumber = "1234567890",
                Position = "mehanik",
                DateOfHire = DateTime.Now,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                DateOfLeave = null,
                IsDeleted = false,
                DepartmentId = 1,
                IsManeger = false
            };

            var hasher = new PasswordHasher<Employee>();
            string pass = "123456";

            employee.PasswordHash = hasher.HashPassword(employee, pass);

            employees.Add(employee);

            Employee manager = new Employee()
            {
                Id = "406e8cf1-acaa-44a8-afec-585ff64bed34",
                Email = "manager@test.bg",
                UserName = "manager@test.bg",
                NormalizedEmail = "manager@test.bg".ToUpper(),
                SecurityStamp = "manager@test.bg".ToUpper(),
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
            Department department = new Department()
            {
                Id = 1,
                Name = "first department",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            };

            return new List<Department> { department };
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
                Description = "row=1;partId=1;partName=test;partPrice=10.00,priceQty=1$",
                SaleAmount = 10.00M,
                Discount = 0,
                VAT = 2.00M,
                FinalAmount = 12.00M,
                PaidAmount = 0,
                UnpaidAmount = 12.00M,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false,
                DateFinish = null,
                StatusId = 1
            };

            return new List<Order> { order };
        }

        public List<OrderPartEmployee> SeedOrdersPartsEmployees()
        {
            OrderPartEmployee ope = new OrderPartEmployee()
            {
                OrderId = 1,
                PartId = 1,
                EmployeeId = "21003785-a275-4139-ae20-af6a6cf8fea8",
                DatetimeAsigned = DateTime.Now,
                StartDatetime = null,
                EndDatetime = null,
                Description = "test",
                IsCompleted = false
            };

            return new List<OrderPartEmployee> { ope };
        }

        public List<Part> SeedParts()
        {
            Part part = new Part()
            {
                Id = 1,
                Name = "test",
                Description = "test",
                OEMNumber = "oemtest",
                CategoryId = 1,
                Unit = "бр",
                Quantity = 1,
                SalePrice = 10.00M,
                VATCategoryId = 1,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            };

            return new List<Part> { part };
        }

        public List<PartCategory> SeedPartCategories()
        {
            PartCategory partCategory = new PartCategory()
            {
                Id = 1,
                Name = "first",
                ImageUrl = "test",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            };

            return new List<PartCategory> { partCategory };
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
            Status status = new Status()
            {
                Id = 1,
                Name = "first_test",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            };

            return new List<Status> { status };
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
            Town town = new Town()
            {
                Id = 1,
                Name = "Sofia",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                DateDeleted = null,
                IsDeleted = false
            };

            return new List<Town> { town };
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