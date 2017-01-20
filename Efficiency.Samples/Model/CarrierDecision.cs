namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarrierDecision")]
    public partial class CarrierDecision
    {
        [Column(TypeName = "numeric")]
        public decimal CarrierDecisionID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FinalFlag { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
    }
}
