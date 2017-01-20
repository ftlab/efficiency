namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.DepartmentJob")]
    public partial class DepartmentJob
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DepartmentJob()
        {
            BorderProtectionScheduleChronometry = new HashSet<BorderProtectionScheduleChronometry>();
            BorderProtectionScheduleDetail = new HashSet<BorderProtectionScheduleDetail>();
            BorderProtectionScheduleReserve = new HashSet<BorderProtectionScheduleReserve>();
            BorderProtectionScheduleTargets = new HashSet<BorderProtectionScheduleTargets>();
            DepartmentTargets = new HashSet<DepartmentTargets>();
            EmployeeDepartmentJob = new HashSet<EmployeeDepartmentJob>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public long DepartmentId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool? IsControl { get; set; }

        public bool? ForSector { get; set; }

        public bool? HasChief { get; set; }

        public int? Priority { get; set; }

        public bool ComputerWork { get; set; }

        public int? Color { get; set; }

        public long? DutyTypeId { get; set; }

        public bool IsNoRotation { get; set; }

        [StringLength(1)]
        public string RestrictedSex { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleChronometry> BorderProtectionScheduleChronometry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleDetail> BorderProtectionScheduleDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleReserve> BorderProtectionScheduleReserve { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleTargets> BorderProtectionScheduleTargets { get; set; }

        public virtual DutyType DutyType { get; set; }

        public virtual OrganizationalStructure OrganizationalStructure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartmentTargets> DepartmentTargets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeDepartmentJob> EmployeeDepartmentJob { get; set; }
    }
}
