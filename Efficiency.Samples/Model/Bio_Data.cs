namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bio_Data
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal IdentifyDocumentID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal InscribeID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal DataTypeID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal DataFormatID { get; set; }

        [Column(TypeName = "text")]
        public string TextData { get; set; }

        public DateTime? DatetimeData { get; set; }

        [StringLength(100)]
        public string StringData { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NumberData { get; set; }

        [Column(TypeName = "image")]
        public byte[] ImageData { get; set; }
    }
}
