namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FMS_CardOperation
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal MigrationCardID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CardOperationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CardOperationTypeID { get; set; }

        [StringLength(100)]
        public string ComputerName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ARMID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UserInfoID { get; set; }

        public DateTime OperationTime { get; set; }
    }
}
