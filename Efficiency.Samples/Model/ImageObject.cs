namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImageObject")]
    public partial class ImageObject
    {
        [Column(TypeName = "numeric")]
        public decimal ImageObjectID { get; set; }

        [Column(TypeName = "image")]
        public byte[] ImageSource { get; set; }
    }
}
