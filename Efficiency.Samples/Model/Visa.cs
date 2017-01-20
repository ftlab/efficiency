namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Visa")]
    public partial class Visa
    {
        [Column(TypeName = "numeric")]
        public decimal VisaID { get; set; }

        [StringLength(30)]
        public string VisaCod { get; set; }

        [StringLength(100)]
        public string VisaNumber { get; set; }

        [StringLength(30)]
        public string RegisterCod { get; set; }

        [StringLength(100)]
        public string RegisterNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VisaTypeID { get; set; }

        [StringLength(30)]
        public string DocumentCod { get; set; }

        [StringLength(100)]
        public string DocumentNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VisaRepetitionID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PurposeID { get; set; }

        public DateTime? IssueDate { get; set; }

        [StringLength(100)]
        public string IssueOrganization { get; set; }

        public DateTime? ValidFromDate { get; set; }

        public DateTime? ValidToDate { get; set; }

        [StringLength(255)]
        public string InvitationOrganization { get; set; }

        [StringLength(100)]
        public string InvitationNumber { get; set; }

        [StringLength(100)]
        public string Route { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DocumentStatusID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NumericRegisterNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NumericDocumentNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VisaClassID { get; set; }

        public DateTime? DecisionDate { get; set; }

        [StringLength(100)]
        public string OfficialFamily { get; set; }

        [StringLength(100)]
        public string DecisionNumber { get; set; }

        [StringLength(30)]
        public string Cod { get; set; }

        [StringLength(100)]
        public string Number { get; set; }

        [StringLength(30)]
        public string BlankCod { get; set; }

        [StringLength(100)]
        public string BlankNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StateInstituteID { get; set; }
    }
}
