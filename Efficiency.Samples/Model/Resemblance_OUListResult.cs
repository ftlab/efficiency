namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.Resemblance_OUListResult")]
    public partial class Resemblance_OUListResult
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ResemblanceID { get; set; }

        [Key]
        [Column(Order = 1)]
        [MaxLength(16)]
        public byte[] HashKey { get; set; }

        public double? Weight { get; set; }

        public int? ErrorCount { get; set; }

        public bool IsDecisiontask { get; set; }

        public virtual Resemblance Resemblance { get; set; }
    }
}
