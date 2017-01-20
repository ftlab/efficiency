namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.v_KaskadFlight")]
    public partial class v_KaskadFlight
    {
        public long? FlightID { get; set; }

        public long? DirectionID { get; set; }

        [StringLength(100)]
        public string Direction { get; set; }

        [Key]
        [StringLength(100)]
        public string FlightNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FlightDateTime { get; set; }

        public long? AirlineFlightID { get; set; }

        public long? CountryFlightID { get; set; }

        public long? CityFlightID { get; set; }
    }
}
