namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransitCategoryChange")]
    public partial class TransitCategoryChange
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OperationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SourceTransitCategoryID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DestinationTransitCategoryID { get; set; }

        [Required]
        [StringLength(255)]
        public string Reason { get; set; }
    }
}
