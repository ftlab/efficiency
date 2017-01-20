namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inscribe")]
    public partial class Inscribe
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal IdentifyDocumentID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal InscribeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal NationalityID { get; set; }

        [Required]
        [StringLength(100)]
        public string Family { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string FamilyLatin { get; set; }

        [StringLength(100)]
        public string NameLatin { get; set; }

        public DateTime? Birthday { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FBirthday { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PermanentResidenceID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PersonStatusID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PhotoID { get; set; }
    }
}
