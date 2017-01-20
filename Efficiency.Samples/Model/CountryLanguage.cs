namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CountryLanguage")]
    public partial class CountryLanguage
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CountryID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal LanguageID { get; set; }
    }
}
