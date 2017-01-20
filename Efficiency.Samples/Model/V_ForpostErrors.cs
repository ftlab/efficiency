namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.V_ForpostErrors")]
    public partial class V_ForpostErrors
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long FileId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengerId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long FIOid { get; set; }

        [StringLength(2000)]
        public string Message { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime CheckDate { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(256)]
        public string FIORus { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(256)]
        public string FIOLat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        [StringLength(3)]
        public string NationalIssue { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(146)]
        public string Document { get; set; }

        [StringLength(50)]
        public string Airline { get; set; }

        [StringLength(10)]
        public string FlightNumber { get; set; }

        [StringLength(128)]
        public string Airport { get; set; }

        public DateTime? ScheduleTimeDep { get; set; }

        public DateTime? ActualTimeDep { get; set; }

        public DateTime? EstimateTimeArr { get; set; }

        public DateTime? ScheduleTimeArr { get; set; }

        public DateTime? ActualTimeArr { get; set; }

        public int? AirlineId { get; set; }

        public DateTime? TimeDep { get; set; }

        public DateTime? TimeArr { get; set; }

        public DateTime? FlightTime { get; set; }
    }
}
