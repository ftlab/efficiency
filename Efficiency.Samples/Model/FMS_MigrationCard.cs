namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FMS_MigrationCard
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal MigrationCardID { get; set; }

        [Required]
        [StringLength(30)]
        public string Cod { get; set; }

        [Required]
        [StringLength(100)]
        public string Number { get; set; }

        [StringLength(100)]
        public string Family { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Patronymic { get; set; }

        [StringLength(100)]
        public string FamilyLatin { get; set; }

        [StringLength(100)]
        public string NameLatin { get; set; }

        [StringLength(100)]
        public string PatronymicLatin { get; set; }

        public DateTime? Birthdate { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [StringLength(30)]
        public string DocumentCod { get; set; }

        [StringLength(100)]
        public string DocumentNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NationalityID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MigrationPurposeID { get; set; }

        [StringLength(30)]
        public string VisaCod { get; set; }

        [StringLength(100)]
        public string VisaNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? InvitationOrganizationCountryID { get; set; }

        [StringLength(100)]
        public string InvitationOrganizationAddress { get; set; }

        [StringLength(100)]
        public string InvitationOrganization { get; set; }

        [StringLength(100)]
        public string InvitationNumber { get; set; }

        public DateTime? ResidenceFrom { get; set; }

        public DateTime? ResidenceTo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StayCountryID { get; set; }

        [StringLength(255)]
        public string StayAddress { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FBirthdate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StayRegionID { get; set; }
    }
}
