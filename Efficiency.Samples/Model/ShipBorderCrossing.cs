namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShipBorderCrossing")]
    public partial class ShipBorderCrossing
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

        [StringLength(100)]
        public string Captain { get; set; }

        [StringLength(100)]
        public string Pilot { get; set; }

        public DateTime? BeginTime { get; set; }

        public DateTime? EndTime { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }

        [StringLength(255)]
        public string Visitor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CommitteeTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CommitteeID { get; set; }

        [StringLength(255)]
        public string CrewInspection { get; set; }

        [StringLength(255)]
        public string FrontierInspection { get; set; }

        [StringLength(255)]
        public string RequestClaim { get; set; }

        public int? PassCount { get; set; }

        [StringLength(100)]
        public string PassCod { get; set; }

        public int? PassNumberFrom { get; set; }

        public int? PassNumberTo { get; set; }

        public DateTime? ExitFromTime { get; set; }
    }
}
