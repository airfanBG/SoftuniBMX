namespace BicycleApp.Services.Models.IdentityModels.Contracts
{    
    public interface IDelivaryAddressDto
    {        
        public string? Country { get; set; }

        public string? PostCode { get; set; }

        public string? District { get; set; }

        public string? Block { get; set; }

        public string? Floor { get; set; }

        public string? Apartment { get; set; }

        public string? Street { get; set; }

        public string? StrNumber { get; set; }
    }
}
