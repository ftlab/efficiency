namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArrivalStation")]
    public partial class ArrivalStation
    {
        [Column(TypeName = "numeric")]
        public decimal ArrivalStationID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CurrentStationFlag { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AirplaneFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CarFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ShipFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TrainFlag { get; set; }

        [StringLength(100)]
        public string RegionCod { get; set; }

        [StringLength(100)]
        public string UnitCod { get; set; }

        [StringLength(100)]
        public string StationCod { get; set; }

        [Required]
        [StringLength(100)]
        public string StationLabel { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ArrivalStationTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FootFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ParentArrivalStationID { get; set; }

        public Guid? Identifier { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ArrivalStationClassID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DeleteFlag { get; set; }
    }
}
