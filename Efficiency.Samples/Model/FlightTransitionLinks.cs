namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("flight.FlightTransitionLinks")]
    public partial class FlightTransitionLinks
    {
        public long ID { get; set; }

        public int AirlineID_1 { get; set; }

        [Required]
        [StringLength(7)]
        public string FlightNumber_1 { get; set; }

        public int AirlineID_2 { get; set; }

        [Required]
        [StringLength(7)]
        public string FlightNumber_2 { get; set; }

        public virtual Airline Airline { get; set; }

        public virtual Airline Airline1 { get; set; }
    }
}
