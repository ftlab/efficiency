namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IdentifyDocument")]
    public partial class IdentifyDocument
    {
        [Column(TypeName = "numeric")]
        public decimal IdentifyDocumentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DocumentCategoryID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CountryID { get; set; }

        [StringLength(30)]
        public string RegisterCod { get; set; }

        [Required]
        [StringLength(100)]
        public string RegisterNumber { get; set; }

        public DateTime? IssueDate { get; set; }

        [StringLength(100)]
        public string IssueOrganization { get; set; }

        public DateTime? ValidToDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DocumentStatusID { get; set; }

        [StringLength(100)]
        public string BlankNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NumericRegisterNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StateInstituteID { get; set; }
    }
}
