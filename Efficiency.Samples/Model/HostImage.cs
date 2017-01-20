namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HostImage")]
    public partial class HostImage
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal HostID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal HostImageID { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ImageObjectID { get; set; }
    }
}
