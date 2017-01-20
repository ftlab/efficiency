namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInfo")]
    public partial class UserInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserInfo()
        {
            EmployeeKaskadUser = new HashSet<EmployeeKaskadUser>();
        }

        [Column(TypeName = "numeric")]
        public decimal UserInfoID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal StatusID { get; set; }

        [Required]
        [StringLength(100)]
        public string LoginName { get; set; }

        [StringLength(100)]
        public string Family { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(100)]
        public string Phone { get; set; }

        public DateTime? Birthday { get; set; }

        [MaxLength(256)]
        public byte[] Password { get; set; }

        public DateTime RegistrationDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SubdivisionID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PositionID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RankID { get; set; }

        [StringLength(30)]
        public string StampNumber { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TestUserFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SecurityAdmin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DeleteFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ReadOnly { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [Column(TypeName = "image")]
        public byte[] Certificate { get; set; }

        [StringLength(100)]
        public string PasswordHash { get; set; }

        public Guid? rowguid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeKaskadUser> EmployeeKaskadUser { get; set; }
    }
}
