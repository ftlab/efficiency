namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentFault")]
    public partial class DocumentFault
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OperationID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal DocumentFaultID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FaultTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ForgedDetectionTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RevealUserID { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StampArrivalStationID { get; set; }

        [StringLength(30)]
        public string StampNumber { get; set; }
    }
}
