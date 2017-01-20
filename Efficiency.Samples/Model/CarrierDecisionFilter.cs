namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarrierDecisionFilter")]
    public partial class CarrierDecisionFilter
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CarrierTypeID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal RegistrationTypeID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal CarrierDecisionID { get; set; }
    }
}
