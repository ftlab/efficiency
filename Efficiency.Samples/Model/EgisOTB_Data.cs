namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanPerson.EgisOTB_Data")]
    public partial class EgisOTB_Data
    {
        public long ID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreationDateTime { get; set; }

        public DateTime RecieptTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateDeparture { get; set; }

        [Required]
        [StringLength(10)]
        public string FlightNumber { get; set; }

        [StringLength(100)]
        public string AirportDeparture { get; set; }

        [Required]
        [StringLength(10)]
        public string OperationType { get; set; }

        [StringLength(50)]
        public string DocumentType { get; set; }

        [StringLength(30)]
        public string CountryIssue { get; set; }

        [StringLength(16)]
        public string DocumentNumber { get; set; }

        [StringLength(30)]
        public string NationalIssue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirth { get; set; }

        [Required]
        [StringLength(256)]
        public string FIO { get; set; }

        [StringLength(3)]
        public string Sex { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateExpiry { get; set; }

        [StringLength(20)]
        public string Locator { get; set; }

        public bool IsProcessed { get; set; }
    }
}
