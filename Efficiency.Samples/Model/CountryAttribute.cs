namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CountryAttribute")]
    public partial class CountryAttribute
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CountryID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal DocumentCategoryID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal CountryAttributeTypeID { get; set; }

        public int? CodLength { get; set; }

        [StringLength(30)]
        public string DocumentICAOCod { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(100)]
        public string DocumentNumberMask { get; set; }

        public int? StayDaysCount { get; set; }

        public int? MinimumAge { get; set; }

        public int? MaximumAge { get; set; }

        [StringLength(30)]
        public string ValidityAge { get; set; }
    }
}
