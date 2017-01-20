namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CBorderCrossing")]
    public partial class CBorderCrossing
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
        public decimal? FlightID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CarrierID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CBorderCrossingTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BoundBorderRoutingID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BoundCarrierBCID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CarrierDecisionID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TransportCompanyID { get; set; }

        public DateTime CrossingTime { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CheckIN { get; set; }
    }
}
