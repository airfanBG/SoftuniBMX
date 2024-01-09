namespace BicycleApp.Data.Models.EntityModels
{
    using BicycleApp.Data.Models.IdentityModels;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static BicycleApp.Common.EntityValidationConstants;

    public class DelivaryAddress
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(DelivaryAddressConstants.CountryMaxValue)]
        public string? Country { get; set; }

        [ForeignKey(nameof(Town))]
        public int TownId { get; set; }
        public Town Town { get; set; } = null!;

        [StringLength(DelivaryAddressConstants.PostCodeMaxValue)]
        public string? PostCode { get; set; }

        [StringLength(DelivaryAddressConstants.DistrictMaxValue)]
        public string? District { get; set; }

        [StringLength(DelivaryAddressConstants.BlockMaxValue)]
        public string? Block { get; set; }

        public string? Floor { get; set; }

        [StringLength(DelivaryAddressConstants.ApartamentMaxValue)]
        public string? Apartment { get; set; }

        [StringLength(DelivaryAddressConstants.StreetMaxValue)]
        public string? Street { get; set; }

        [StringLength(DelivaryAddressConstants.StreetNumberMaxValue)]
        public string? StrNumber { get; set; }
    }
}
