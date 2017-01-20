namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanPerson.PassengerJournal")]
    public partial class PassengerJournal
    {
        public long ID { get; set; }

        public long PassengerFileID { get; set; }

        [Required]
        [StringLength(50)]
        public string OperationType { get; set; }

        [StringLength(128)]
        public string DocumentType { get; set; }

        [StringLength(128)]
        public string CountryIssue { get; set; }

        [StringLength(16)]
        public string DocumentNumber { get; set; }

        [StringLength(30)]
        public string NationalIssue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirth { get; set; }

        [StringLength(3)]
        public string Sex { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateExpiry { get; set; }

        [StringLength(256)]
        public string FIOPassenger { get; set; }

        [StringLength(10)]
        public string FlightNumberIATA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateDeparture { get; set; }

        [StringLength(30)]
        public string AirportDeparture { get; set; }

        [StringLength(20)]
        public string Locator { get; set; }

        public virtual PassengerFile PassengerFile { get; set; }
    }
}
