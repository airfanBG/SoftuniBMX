namespace BicycleApp.Services.Services.Factory
{
    using System;
    using System.Text;

    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.IdentityModels;

    public class ModelsFactory : IModelsFactory
    {
        public Client CreateNewClientModel(ClientRegisterDto clientRegisterDto)
        {
            //Transform the address dto in to a string
            var sb = new StringBuilder();
            var innerDto = clientRegisterDto.DelivaryAddress;

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
    }
}
