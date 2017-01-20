namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CountryToCountryGroup")]
    public partial class CountryToCountryGroup
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CountryGroupID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CountryID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ReadOnly { get; set; }
    }
}
