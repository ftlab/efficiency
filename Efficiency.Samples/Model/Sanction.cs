namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sanction")]
    public partial class Sanction
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OperationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SourceOperationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SanctionTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ReportedID { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }

        [StringLength(255)]
        public string Reason { get; set; }

        [StringLength(255)]
        public string Facts { get; set; }

        [StringLength(255)]
        public string WhichSend { get; set; }

        public DateTime? SendDate { get; set; }

        [StringLength(100)]
        public string SendDocumentNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SanctionInitiatorID { get; set; }
    }
}
