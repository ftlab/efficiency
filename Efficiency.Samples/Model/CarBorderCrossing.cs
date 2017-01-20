namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarBorderCrossing")]
    public partial class CarBorderCrossing
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal ArrivalStationID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal BorderRoutingID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal CarrierTypeID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal CarrierBCID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LadingTypeID { get; set; }

        public int? SealCount { get; set; }

        [StringLength(255)]
        public string Route { get; set; }

        [StringLength(100)]
        public string TrailerRegisterNumber { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }
    }
}
