namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bio_ChipSignCheck
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OperationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EFSODPresent { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ECIHashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SignedAttributeSignValid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG1HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG2HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG3HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG4HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG5HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG6HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG7HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG8HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG9HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG10HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG11HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG12HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG13HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG14HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG15HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DG16HashEqual { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PassportValid { get; set; }

        [StringLength(255)]
        public string ErrorMessage { get; set; }
    }
}
