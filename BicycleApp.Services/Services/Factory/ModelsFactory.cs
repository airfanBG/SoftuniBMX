namespace BicycleApp.Services.Services.Factory
{
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models;
    using BicycleApp.Services.Models.IdentityModels;
    using BicycleApp.Services.Models.Supply;
    using System;
    using System.Text;

    public class ModelsFactory : IModelsFactory
    {
        public BikeStandartModel CreateNewBikeStandartModel(BikeStandartTypeAddDto bikeStandartTypeAddDto)
        {
            return new BikeStandartModel()
            {
                ModelName = bikeStandartTypeAddDto.ModelName,
                Description = bikeStandartTypeAddDto.Description,
                ImageUrl = bikeStandartTypeAddDto.ImageUrl,
                Price = bikeStandartTypeAddDto.Price
            };
        }

        public Client CreateNewClientModel(ClientRegisterDto clientRegisterDto)
        {
            //Transform the address dto in to a string
            var sb = new StringBuilder();
            ClientAddressDto innerDto = clientRegisterDto.DelivaryAddress;

            if (!string.IsNullOrWhiteSpace(innerDto.Country))
            {
                sb.Append($"{innerDto.Country} ");
            }
            if (!string.IsNullOrWhiteSpace(innerDto.PostCode))
            {
                sb.Append($"{innerDto.PostCode} ");
            }
            if (!string.IsNullOrWhiteSpace(innerDto.District))
            {
                sb.Append($"{innerDto.District} ");
            }
            if (!string.IsNullOrWhiteSpace(innerDto.Block))
            {
                sb.Append($"{innerDto.Block} ");
            }
            if (innerDto.Floor.HasValue)
            {
                sb.Append($"{innerDto.Floor} ");
            }
            if (!string.IsNullOrWhiteSpace(innerDto.Apartment))
            {
                sb.Append($"{innerDto.Apartment} ");
            }
            if (!string.IsNullOrWhiteSpace(innerDto.Street))
            {
                sb.Append($"{innerDto.Street} ");
            }
            if (!string.IsNullOrWhiteSpace(innerDto.StrNumber))
            {
                sb.Append($"{innerDto.StrNumber}");
            }

            return new Client()
            {

                FirstName = clientRegisterDto.FirstName,
                LastName = clientRegisterDto.LastName,
                Email = clientRegisterDto.Email,
                NormalizedEmail = clientRegisterDto.Email.ToUpper(),
                UserName = clientRegisterDto.Email,
                NormalizedUserName = clientRegisterDto.Email.ToUpper(),
                PhoneNumber = clientRegisterDto.PhoneNumber,
                DelivaryAddress = sb.ToString(),
                IBAN = clientRegisterDto.IBAN,
                Balance = clientRegisterDto.Balance,
                DateCreated = DateTime.UtcNow,
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false
            };
        }

        public Comment CreateNewComment(CommentAddDto commentAddDto)
        {
            return new Comment()
            {
                ClientId = commentAddDto.ClientId,
                PartId = commentAddDto.PartId,
                DateCreated = DateTime.UtcNow,
                Description = commentAddDto.Description,
                Title = commentAddDto.Title,
                DateUpdated = null
            };
        }

        public Delivary CreateNewDelivery(CreateDelivedryDto createDelivedryDto)
        {
            return new Delivary()
            {
                PartId = createDelivedryDto.PartId,
                Note = createDelivedryDto.Note,
                QuantityDelivered = createDelivedryDto.QuantityDelivered,
                SuplierId = createDelivedryDto.SuplierId,
                DateDelivered = DateTime.UtcNow,
                DateDeleted = null,
                DateUpdated = DateTime.UtcNow,
                IsDeleted=false
            };
        }

        public Department CreateNewDepartment(string departmentName)
        {
            return new Department()
            {
                Name = departmentName,
                DateCreated = DateTime.UtcNow,
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false
            };
        }

        public Employee CreateNewEmployee(EmployeeRegisterDto employeeRegisterDto)
        {
            return new Employee()
            {
                FirstName = employeeRegisterDto.FirstName,
                LastName = employeeRegisterDto.LastName,
                Email = employeeRegisterDto.Email,
                DateCreated = DateTime.UtcNow,
                DateUpdated = null,
                DateOfLeave = null,
                DateOfHire = DateTime.Parse(employeeRegisterDto.DateOfHire),
                IsDeleted = false,
                IsManeger = employeeRegisterDto.IsManeger,
                NormalizedEmail = employeeRegisterDto.Email.ToUpper(),
                NormalizedUserName = employeeRegisterDto.Email.ToUpper(),
                PhoneNumber = employeeRegisterDto.PhoneNumber,
                UserName = employeeRegisterDto.Email,
                Position = employeeRegisterDto.Position
            };
        }

        public Suplier CreateNewSuplier(CreateSuplierDto createSuplierDto)
        {
            return new Suplier()
            {
                Name= createSuplierDto.Name,
                VATNumber= createSuplierDto.VATNumber,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                DateDeleted = null,
                IsDeleted = false,
                CategoryName = createSuplierDto.CategoryName,
                Address = createSuplierDto.Address,
                ContactName = createSuplierDto.ContactName,
                Email = createSuplierDto.Email,
                PhoneNumeber = createSuplierDto.PhoneNumeber
            };
        }

        public Town CreateNewTown(string townName)
        {
            return new Town()
            {
                Name = townName,
                DateCreated = DateTime.UtcNow,
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false
            };
        }

        public Part CreatePart(PartAddDto partAddDto)
        {
            return new Part()
            {
                Name = partAddDto.Name,
                Description = partAddDto.Description,
                VATCategoryId = partAddDto.VATCategoryId,
                CategoryId = partAddDto.CategoryId,
                SalePrice = partAddDto.SalePrice,
                DateCreated = DateTime.UtcNow,
                DateDeleted = null,
                DateUpdated = null,
                IsDeleted = false,
                Intend = partAddDto.Intend,
                OEMNumber = partAddDto.OEMNumber,
                Quantity = partAddDto.Quantity,
                Type = partAddDto.Type
            };
        }

        public PartOrder CreateNewPartOrder(CreatePartOrderDto partOrderDto)
        {
            return new PartOrder()
            {
                PartId = partOrderDto.PartId,
                Quantity = partOrderDto.Quantity,
                SuplierId = partOrderDto.SuplierId,
                Note = partOrderDto.Note,
                DateCreated = DateTime.UtcNow,
                DateDeleted = null,
                DateUpdated = DateTime.UtcNow,
                IsDeleted = false,
            };
        }
    }
}
