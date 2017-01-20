namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ADP_PriorLawClauseIntringement
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal LawClauseID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal LawID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal AdministrativeIntringementID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Part { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Paragraph { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Point { get; set; }
    }
}
