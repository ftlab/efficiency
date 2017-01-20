namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DepthControl")]
    public partial class DepthControl
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OperationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DecisionID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FaultTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ReportedID { get; set; }

        [StringLength(2000)]
        public string Reason { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DecisionMakingUserID { get; set; }

        [StringLength(2000)]
        public string Notes { get; set; }

        [StringLength(30)]
        public string BookRecordNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CommitteeTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CommitteeID { get; set; }

        [StringLength(255)]
        public string FaultAdditional { get; set; }
    }
}
