namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserAction")]
    public partial class UserAction
    {
        [Column(TypeName = "numeric")]
        public decimal UserActionID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ActionGroupID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ActionTypeID { get; set; }

        public DateTime ActionTime { get; set; }

        [Required]
        [StringLength(100)]
        public string ComputerName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ARMID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UserInfoID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ModuleID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BorderCrossingID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OperationID { get; set; }

        [StringLength(255)]
        public string String1 { get; set; }

        [StringLength(255)]
        public string String2 { get; set; }

        [StringLength(255)]
        public string String3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Number1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Number2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Number3 { get; set; }

        public DateTime? Date1 { get; set; }

        public DateTime? Date2 { get; set; }

        public DateTime? Date3 { get; set; }

        [StringLength(255)]
        public string String4 { get; set; }

        [StringLength(255)]
        public string String5 { get; set; }

        [StringLength(255)]
        public string String6 { get; set; }

        [StringLength(255)]
        public string String7 { get; set; }

        [StringLength(255)]
        public string String8 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ArrivalStationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Number5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Number4 { get; set; }
    }
}
