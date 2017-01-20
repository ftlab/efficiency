namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PassengerTypeChange")]
    public partial class PassengerTypeChange
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OperationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SourcePassengerTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DestinationPassengerTypeID { get; set; }

        [Required]
        [StringLength(255)]
        public string Reason { get; set; }
    }
}
