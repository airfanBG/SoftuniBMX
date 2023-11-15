namespace BicycleApp.Data.Models.EntityModels
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class BikeModelPart
    {
        [ForeignKey(nameof(BikeModel))]
        public int BikeModelId { get; set; }

        public virtual BikeStandartModel BikeModel { get; set; } = null!;

        [ForeignKey(nameof(Part))]
        public int PartId { get; set; }

        public virtual Part Part { get; set; } = null!;
    }
}
