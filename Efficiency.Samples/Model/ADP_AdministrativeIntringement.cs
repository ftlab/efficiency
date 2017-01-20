namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ADP_AdministrativeIntringement
    {
        [Column(TypeName = "numeric")]
        public decimal? PriorQualificationClauseID { get; set; }

        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal AdministrativeIntringementID { get; set; }

        [StringLength(255)]
        public string IntrigementFacts { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PriorQualificationLawID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IntringementStatusID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PriorQualificationPart { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PriorQualificationParagraph { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PriorQualificationPoint { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SourceOperationID { get; set; }
    }
}
