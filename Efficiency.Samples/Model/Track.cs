namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Track")]
    public partial class Track
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

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal Position { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CountryID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CityID { get; set; }
    }
}
