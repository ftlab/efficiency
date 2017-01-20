namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("recommd.ExportParameters")]
    public partial class ExportParameters
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string Job { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal Ndb { get; set; }

        public bool AllowExport { get; set; }
    }
}
