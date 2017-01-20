namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.ReadRFID")]
    public partial class ReadRFID
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

        [StringLength(3)]
        public string Sex { get; set; }

        [StringLength(9)]
        public string NationalityCode { get; set; }

        [StringLength(9)]
        public string IssuingStateCode { get; set; }

        [StringLength(10)]
        public string MRZ_Type { get; set; }

        [StringLength(10)]
        public string DocumentClassCode { get; set; }

        [StringLength(16)]
        public string DocumentNumber { get; set; }

        [StringLength(128)]
        public string Surname { get; set; }

        [StringLength(128)]
        public string GivenNames { get; set; }

        [StringLength(256)]
        public string MRZ_Strings { get; set; }

        [StringLength(256)]
        public string SurnameGivenNames { get; set; }

        public byte[] RawDataFoto { get; set; }

        public byte[] RawData_1E { get; set; }

        public byte[] RawData_01 { get; set; }

        public virtual Reading Reading { get; set; }
    }
}
