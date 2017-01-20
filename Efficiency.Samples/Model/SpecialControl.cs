namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpecialControl")]
    public partial class SpecialControl
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OperationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DocumentStatusID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CommitteeTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CommitteeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ForgedDetectionTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DecisionID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FaultTypeID { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IdentifyDocumentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? InscribeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VisaFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ReportedID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DecisionMakingUserID { get; set; }

        [StringLength(2000)]
        public string Notes { get; set; }

        [StringLength(30)]
        public string BookRecordNumber { get; set; }

        [StringLength(255)]
        public string FaultAdditional { get; set; }
    }
}
