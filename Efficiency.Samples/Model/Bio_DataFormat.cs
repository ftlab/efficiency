namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bio_DataFormat
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal DataTypeID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal DataFormatID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DomainTypeID { get; set; }
    }
}
