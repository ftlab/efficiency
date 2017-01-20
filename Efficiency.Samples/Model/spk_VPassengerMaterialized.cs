namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class spk_VPassengerMaterialized
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal IdentifyDocumentID { get; set; }

        [StringLength(30)]
        public string RegisterCod { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string RegisterNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NumericRegisterNumber { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal DocumentCategoryID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal InscribeID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string Family { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string FamilyLatin { get; set; }

        [StringLength(100)]
        public string NameLatin { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "numeric")]
        public decimal NationalityID { get; set; }

        public DateTime? Birthday { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FBirthday { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CrossingLabelID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AddedMakeID { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "numeric")]
        public decimal ArrivalStationID { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "numeric")]
        public decimal PassengerTypeID { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "numeric")]
        public decimal BorderRoutingID { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "numeric")]
        public decimal DecisionID { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "numeric")]
        public decimal OperationID { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime OperationTime { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "numeric")]
        public decimal UserInfoID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PurposeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FlightID { get; set; }

        [Column("_FullData")]
        public int? C_FullData { get; set; }
    }
}
