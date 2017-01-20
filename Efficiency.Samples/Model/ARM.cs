namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ARM")]
    public partial class ARM
    {
        [Column(TypeName = "numeric")]
        public decimal ARMID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string FriendlyName { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }

        [StringLength(100)]
        public string ARMLogin { get; set; }

        [StringLength(100)]
        public string ARMPassword { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UnusedFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AutonomyFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AirplaneFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CarFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ShipFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TrainFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FootFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CenterFlag { get; set; }
    }
}
