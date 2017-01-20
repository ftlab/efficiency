namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IM_ArriveDeparture
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal ArrivalStationID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string ArrivalStationName { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal NationalityID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string NationalityName { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string Family { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string DocumentCategoryName { get; set; }

        [StringLength(30)]
        public string DocumentRegisterCod { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string DocumentRegisterNumber { get; set; }

        [StringLength(100)]
        public string VisaTypeName { get; set; }

        [StringLength(30)]
        public string VisaCod { get; set; }

        [StringLength(100)]
        public string VisaNumber { get; set; }

        [StringLength(30)]
        public string VisaRegisterCod { get; set; }

        [StringLength(100)]
        public string VisaRegisterNumber { get; set; }

        public DateTime? VisaValidToDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PurposeID { get; set; }

        [StringLength(100)]
        public string PurposeName { get; set; }

        [StringLength(255)]
        public string InvitationOrganization { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime InOperationTime { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime OutOperationTime { get; set; }
    }
}
