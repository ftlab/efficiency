namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subdivision")]
    public partial class Subdivision
    {
        [Column(TypeName = "numeric")]
        public decimal SubdivisionID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ArrivalStationID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ParentSubdivisionID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ChiefID { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DeleteFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ReadOnly { get; set; }
    }
}
