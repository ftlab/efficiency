namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Filtration")]
    public partial class Filtration
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OperationID { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DecisionID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CommitteeTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CommitteeID { get; set; }

        [StringLength(255)]
        public string AdditionalDocumentData { get; set; }

        [StringLength(100)]
        public string FlightOut { get; set; }

        [StringLength(100)]
        public string RouteOut { get; set; }
    }
}
