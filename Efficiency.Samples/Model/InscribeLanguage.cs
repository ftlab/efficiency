namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InscribeLanguage")]
    public partial class InscribeLanguage
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal IdentifyDocumentID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal InscribeID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal SpokenLanguageID { get; set; }
    }
}
