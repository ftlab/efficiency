namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IM_Prepared
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal TimeShearID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal ArrivalStationID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string ArrivalStationName { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "numeric")]
        public decimal IdentifyDocumentID { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "numeric")]
        public decimal InscribeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BorderRoutingID { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "numeric")]
        public decimal NationalityID { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string NationalityName { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(100)]
        public string DocumentCategoryName { get; set; }

        [StringLength(30)]
        public string DocumentRegisterCod { get; set; }

        [StringLength(100)]
        public string DocumentRegisterNumber { get; set; }

        [StringLength(30)]
        public string VisaCod { get; set; }

        [StringLength(100)]
        public string VisaNumber { get; set; }

        [StringLength(30)]
        public string VisaRegisterCod { get; set; }

        [StringLength(100)]
        public string VisaRegisterNumber { get; set; }

        public DateTime? VisaValidToDate { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string Family { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public DateTime? Birthday { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FBirthday { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [StringLength(100)]
        public string VisaTypeName { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string BorderRoutingName { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime OperationTime { get; set; }

        [StringLength(255)]
        public string InvitationOrganization { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PurposeID { get; set; }

        [StringLength(100)]
        public string PurposeName { get; set; }
    }
}
