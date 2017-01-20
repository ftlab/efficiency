namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transfert")]
    public partial class Transfert
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ArrivalStationOutID { get; set; }

        [StringLength(100)]
        public string FlightOut { get; set; }

        [StringLength(100)]
        public string RouteOut { get; set; }

        public DateTime? OutDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RealOutFlag { get; set; }

        [StringLength(100)]
        public string RealFlightOut { get; set; }

        [StringLength(100)]
        public string RealRouteOut { get; set; }

        public DateTime? RealOutDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RealArrivalStationOutID { get; set; }
    }
}
