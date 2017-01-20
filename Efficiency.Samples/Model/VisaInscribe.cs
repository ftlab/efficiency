namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VisaInscribe")]
    public partial class VisaInscribe
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal VisaID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal VisaInscribeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal NationalityID { get; set; }

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
        public string PlaceOfBirth { get; set; }
    }
}
