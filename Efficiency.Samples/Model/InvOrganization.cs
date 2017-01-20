namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvOrganization")]
    public partial class InvOrganization
    {
        [Column(TypeName = "numeric")]
        public decimal InvOrganizationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AdditionalJobID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OrgStatusID { get; set; }

        public int? DKSNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(30)]
        public string RegistrationNumber { get; set; }

        [StringLength(100)]
        public string RegistrationOrg { get; set; }

        [StringLength(30)]
        public string Zip { get; set; }

        [StringLength(100)]
        public string Region { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(30)]
        public string Phone { get; set; }

        [StringLength(30)]
        public string Fax { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        [StringLength(100)]
        public string FIO { get; set; }

        [StringLength(100)]
        public string LeaderPost { get; set; }

        [StringLength(255)]
        public string Executor { get; set; }

        [StringLength(100)]
        public string FIO2 { get; set; }

        [StringLength(255)]
        public string PostAddress { get; set; }

        [StringLength(100)]
        public string GNI { get; set; }

        public DateTime? ClosingDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? JobFlag { get; set; }

        public DateTime? JobDate { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }
    }
}
