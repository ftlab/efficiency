namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Deportation")]
    public partial class Deportation
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OperationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ReportedID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DeportationStationID { get; set; }

        [StringLength(100)]
        public string DeportationFlight { get; set; }

        public DateTime? DeportationDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RealDeportationFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RealDeportationStationID { get; set; }

        [StringLength(100)]
        public string RealDeportationFlight { get; set; }

        public DateTime? RealDeportationDate { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }
    }
}
