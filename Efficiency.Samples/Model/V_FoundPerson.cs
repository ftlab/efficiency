namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.V_FoundPerson")]
    public partial class V_FoundPerson
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassangerID { get; set; }

        public long? FileId { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime PrecheckDate { get; set; }

        public DateTime? CheckResultDate { get; set; }

        public DateTime? RevealDate { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(256)]
        public string FIOPassenger_RUS { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(256)]
        public string FIOPassenger { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirth { get; set; }

        public int? FoundCount { get; set; }

        [StringLength(50)]
        public string Airline { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long FPDecisionID { get; set; }

        [StringLength(50)]
        public string Checked { get; set; }

        [StringLength(10)]
        public string FlightNumber { get; set; }

        [StringLength(56)]
        public string Note { get; set; }

        public bool? IsArrived { get; set; }

        [StringLength(3)]
        public string Citizenship { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(146)]
        public string Document { get; set; }

        [StringLength(128)]
        public string AirportDepartureCode { get; set; }

        public DateTime? scheduleTimeDep { get; set; }

        public DateTime? actualTimeDep { get; set; }

        public DateTime? estimateTimeArr { get; set; }

        public DateTime? scheduleTimeArr { get; set; }

        public DateTime? actualTimeArr { get; set; }

        public int? AirlineId { get; set; }

        public DateTime? ArrivedDate { get; set; }

        public DateTime? TimeDep { get; set; }

        public DateTime? TimeArr { get; set; }

        public DateTime? FlightTime { get; set; }

        public int? Difference { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FoundCountInForpost { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FoundCountInOu { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FoundCountInForpost2 { get; set; }
    }
}
