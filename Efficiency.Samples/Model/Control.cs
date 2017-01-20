namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.Control")]
    public partial class Control
    {
        public long ID { get; set; }

        public Guid AID { get; set; }

        public long Registration_ID { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Changed { get; set; }

        public byte? DateBirthFlag { get; set; }

        public int? FindLimit { get; set; }

        public int? FindOU { get; set; }

        public int? DirectMatch { get; set; }

        public int? FindLostDoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateExpiry { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateIssue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirth { get; set; }

        public DateTime? StartControl { get; set; }

        public DateTime? EndControl { get; set; }

        public DateTime? RunFindOU { get; set; }

        public DateTime? OK { get; set; }

        public DateTime? MakeNote { get; set; }

        public DateTime? DelNote { get; set; }

        public TimeSpan? TimeFindOU { get; set; }

        public TimeSpan? TimeFind { get; set; }

        [StringLength(3)]
        public string Sex { get; set; }

        [StringLength(10)]
        public string FligthNumber { get; set; }

        [StringLength(16)]
        public string DocumNumber { get; set; }

        [StringLength(30)]
        public string NationalityCode { get; set; }

        [StringLength(128)]
        public string TypeDocument { get; set; }

        [StringLength(128)]
        public string Nationality { get; set; }

        [StringLength(128)]
        public string Location { get; set; }

        [StringLength(256)]
        public string AddInfo { get; set; }

        [StringLength(257)]
        public string FioLatin { get; set; }

        [StringLength(257)]
        public string FioRus { get; set; }

        [StringLength(1024)]
        public string WarnDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CrossingLabelID { get; set; }

        public virtual Registration Registration { get; set; }
    }
}
