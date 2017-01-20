namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Photo")]
    public partial class Photo
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OperationID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal PhotoID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ImageObjectID { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }
    }
}
