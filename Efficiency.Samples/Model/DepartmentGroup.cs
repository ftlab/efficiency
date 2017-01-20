namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.DepartmentGroup")]
    public partial class DepartmentGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DepartmentGroup()
        {
            BorderProtectionScheduleChronometry = new HashSet<BorderProtectionScheduleChronometry>();
            BorderProtectionScheduleDetail = new HashSet<BorderProtectionScheduleDetail>();
            EmployeeDepartmentGroup = new HashSet<EmployeeDepartmentGroup>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public long DepartmentId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleChronometry> BorderProtectionScheduleChronometry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleDetail> BorderProtectionScheduleDetail { get; set; }

        public virtual OrganizationalStructure OrganizationalStructure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeDepartmentGroup> EmployeeDepartmentGroup { get; set; }
    }
}
