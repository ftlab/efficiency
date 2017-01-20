namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CountryGroup")]
    public partial class CountryGroup
    {
        [Column(TypeName = "numeric")]
        public decimal CountryGroupID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ParentCountryGroupID { get; set; }

        public int HierarchyLevel { get; set; }
    }
}
