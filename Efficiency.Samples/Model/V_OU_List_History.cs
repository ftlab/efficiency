namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oulist.V_OU_List_History")]
    public partial class V_OU_List_History
    {
        [MaxLength(16)]
        public byte[] HashKey { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? DeletedDateTime { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal Ndb { get; set; }

        [Column(TypeName = "image")]
        public byte[] BioData { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }
    }
}
