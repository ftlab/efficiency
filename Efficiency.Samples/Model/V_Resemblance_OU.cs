namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.V_Resemblance_OU")]
    public partial class V_Resemblance_OU
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ResemblanceID { get; set; }

        [Key]
        [Column(Order = 1)]
        [MaxLength(16)]
        public byte[] HashKey { get; set; }

        public long? OuId { get; set; }

        public double? Weight { get; set; }

        public int? ErrorCount { get; set; }

        [StringLength(100)]
        public string FIO { get; set; }

        [StringLength(6)]
        public string BirthDate { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [StringLength(4)]
        public string Job { get; set; }

        public byte? Direction { get; set; }

        public DateTime? IssueDate { get; set; }

        [StringLength(2000)]
        public string Comment { get; set; }

        [StringLength(4)]
        public string Country { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsDecisiontask { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool AllowExport { get; set; }
    }
}
