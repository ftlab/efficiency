namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StateInstitute")]
    public partial class StateInstitute
    {
        [Column(TypeName = "numeric")]
        public decimal StateInstituteID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ParentStateInstituteID { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DeleteFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ReadOnly { get; set; }
    }
}
