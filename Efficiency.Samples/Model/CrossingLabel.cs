namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CrossingLabel")]
    public partial class CrossingLabel
    {
        [Column(TypeName = "numeric")]
        public decimal CrossingLabelID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DeleteFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TaskFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ReadOnly { get; set; }

        [Column(TypeName = "numeric")]
        public decimal InFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OutFlag { get; set; }
    }
}
