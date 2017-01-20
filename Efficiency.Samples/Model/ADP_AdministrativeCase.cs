namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ADP_AdministrativeCase
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal AdministrativeCaseID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? InitiatorID { get; set; }

        [StringLength(100)]
        public string Number { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SheetNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CaseStartLegalDocumentID { get; set; }

        [StringLength(255)]
        public string Appeals { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DistraintNumber { get; set; }

        public DateTime? SignatureDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        public DateTime? EntryBanFrom { get; set; }

        public DateTime? EntryBanTo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AdministrativeIntringementID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QualificationLawID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QualificationLawClauseID { get; set; }
    }
}
