namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Operation")]
    public partial class Operation
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OperationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OperationTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UserInfoID { get; set; }

        public DateTime OperationTime { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ARMID { get; set; }

        [Required]
        [StringLength(100)]
        public string ComputerName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CheckIN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SubdivisionID { get; set; }

        [StringLength(30)]
        public string StampNumber { get; set; }
    }
}
