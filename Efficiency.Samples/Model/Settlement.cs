namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settlement")]
    public partial class Settlement
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CountryID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal RegionID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal SettlementID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DeleteFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ReadOnly { get; set; }
    }
}
