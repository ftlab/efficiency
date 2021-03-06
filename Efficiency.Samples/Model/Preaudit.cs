namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Preaudit")]
    public partial class Preaudit
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
        public decimal? SuspectFaultTypeID { get; set; }

        [StringLength(255)]
        public string SuspectFaultNotes { get; set; }
    }
}
