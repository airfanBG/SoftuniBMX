namespace BicycleApp.Services.Models.IdentityModels.Contracts
{
    public interface IBaseClientDto
    {       
        public string ClientId { get; set; }
        public string? FirstName { get; set; }       
        public string? LastName { get; set; }        
        public string? Email { get; set; }        
        public string? PhoneNumber { get; set; }       
        public string? Town { get; set; }       
        public string? IBAN { get; set; }        
        public decimal Balance { get; set; }       
        public ClientAddressDto DelivaryAddress { get; set; } 
    }
}
