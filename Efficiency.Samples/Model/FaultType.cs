namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FaultType")]
    public partial class FaultType
    {
        [Column(TypeName = "numeric")]
        public decimal FaultTypeID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ParentFaultTypeID { get; set; }

        public int HierarchyLevel { get; set; }
    }
}
