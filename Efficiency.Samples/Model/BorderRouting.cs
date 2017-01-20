namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BorderRouting")]
    public partial class BorderRouting
    {
        [Column(TypeName = "numeric")]
        public decimal BorderRoutingID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public Guid? rowguid { get; set; }
    }
}
