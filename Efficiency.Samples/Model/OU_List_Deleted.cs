namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oulist.OU_List_Deleted")]
    public partial class OU_List_Deleted
    {
        [Key]
        [MaxLength(16)]
        public byte[] HashKey { get; set; }

        public DateTime DeletedDateTime { get; set; }

        public int N { get; set; }

        [StringLength(100)]
        public string FIO { get; set; }

        [StringLength(6)]
        public string BirthDate { get; set; }

        [StringLength(4)]
        public string Country { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [StringLength(4)]
        public string Job { get; set; }

        [StringLength(4)]
        public string Note { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Oper { get; set; }

        public DateTime? InsertDate { get; set; }

        public DateTime? IssueDate { get; set; }

        [StringLength(2000)]
        public string Comment { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Ndb { get; set; }

        [Column(TypeName = "image")]
        public byte[] BioData { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }
    }
}
