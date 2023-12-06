using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BicycleApp.Services.Models.Supply
{
    public class DeliveryDetailsDto
    {
        public int Id { get; set; }

        public int PartId { get; set; }

        public double QuantityDelivered { get; set; }

        public string? Note { get; set; }

        public DateTime DateDelivered { get; set; }

        public int SuplierId { get; set; }
    }
}
