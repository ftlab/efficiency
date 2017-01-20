namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Purpose")]
    public partial class Purpose
    {
        [Column(TypeName = "numeric")]
        public decimal PurposeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PurposeGroupID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MigrationPurposeID { get; set; }
    }
}
