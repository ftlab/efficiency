namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.ReadMRZ")]
    public partial class ReadMRZ
    {
        public long ID { get; set; }

        public Guid AID { get; set; }

        public long Reading_ID { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Changed { get; set; }

        public byte? DateBirthFlag { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirth { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateExpiry { get; set; }

        [StringLength(2)]
        public string DocumentCategory { get; set; }

        [StringLength(3)]
        public string Sex { get; set; }

        [StringLength(16)]
        public string DocumentNumber { get; set; }

        [StringLength(30)]
        public string NationalIssue { get; set; }

        [StringLength(30)]
        public string IssuingStateCode { get; set; }

        [StringLength(128)]
        public string Surname { get; set; }

        [StringLength(128)]
        public string Surname_RUS { get; set; }

        [StringLength(128)]
        public string GivenName { get; set; }

        [StringLength(128)]
        public string GivenName_RUS { get; set; }

        public virtual Reading Reading { get; set; }
    }
}
