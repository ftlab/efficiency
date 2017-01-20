namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flight")]
    public partial class Flight
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal ArrivalStationID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal BorderRoutingID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal FlightID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FlightTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CarrierTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CarrierBCID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CarrierParkID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TransportCompanyID { get; set; }

        [Required]
        [StringLength(100)]
        public string FlightNumber { get; set; }

        public DateTime FlightTime { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FlightModeID { get; set; }
    }
}
