namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AirplaneBorderCrossing")]
    public partial class AirplaneBorderCrossing
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

        public DateTime? BeginTime { get; set; }

        public DateTime? EndTime { get; set; }

        public DateTime? LadderOutTime { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PassengerNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VIPNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DIPNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PatientNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CrewNumber { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CommitteeTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CommitteeID { get; set; }
    }
}
