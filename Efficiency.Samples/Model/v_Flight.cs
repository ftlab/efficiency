namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("flight.v_Flight")]
    public partial class v_Flight
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AirlineID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long DirectionID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime DateDeparture { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(7)]
        public string FlightNumber { get; set; }

        [StringLength(10)]
        public string FlightNumberIATA { get; set; }

        [StringLength(10)]
        public string FlightNumberINT { get; set; }

        [StringLength(128)]
        public string Airport { get; set; }

        public DateTime? scheduleTimeArr { get; set; }

        [StringLength(10)]
        public string acType { get; set; }

        public DateTime? actualTimeArr { get; set; }

        public DateTime? actualTimeDep { get; set; }

        public DateTime? estimateTimeArr { get; set; }

        public DateTime? scheduleTimeDep { get; set; }

        public int? PAX_ECON { get; set; }

        public int? PAX_BUS { get; set; }

        public int? PAX_FIRST { get; set; }

        public int? PAX_ALL { get; set; }

        [StringLength(20)]
        public string flId { get; set; }
    }
}
