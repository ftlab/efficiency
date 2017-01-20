namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatTypeObject")]
    public partial class StatTypeObject
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal StatTypeID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal StatObjectID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EnabledFlag { get; set; }
    }
}
