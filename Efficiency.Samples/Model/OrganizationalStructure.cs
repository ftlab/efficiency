namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.OrganizationalStructure")]
    public partial class OrganizationalStructure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrganizationalStructure()
        {
            DepartmentGroup = new HashSet<DepartmentGroup>();
            DepartmentJob = new HashSet<DepartmentJob>();
            DepartmentStaff = new HashSet<DepartmentStaff>();
            DepartmentTargets = new HashSet<DepartmentTargets>();
            DepartmentWorkSchedule = new HashSet<DepartmentWorkSchedule>();
            DepartmentWorkSchedule1 = new HashSet<DepartmentWorkSchedule>();
            EmployeeOrganizationalStructure = new HashSet<EmployeeOrganizationalStructure>();
            EmployeeOrganizationalStructure1 = new HashSet<EmployeeOrganizationalStructure>();
            EmployeeOrganizationalStructure2 = new HashSet<EmployeeOrganizationalStructure>();
            EmployeeOrganizationalStructure3 = new HashSet<EmployeeOrganizationalStructure>();
            BorderProtectionPlan = new HashSet<BorderProtectionPlan>();
            BorderProtectionScheduleHeader = new HashSet<BorderProtectionScheduleHeader>();
            OrganizationalStructure1 = new HashSet<OrganizationalStructure>();
            OrganizationalStructureChief = new HashSet<OrganizationalStructureChief>();
            ReportTemplate = new HashSet<ReportTemplate>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Name { get; set; }

        public long TypeId { get; set; }

        public long? ParentId { get; set; }

        public bool? IsDeleted { get; set; }

        public long? WorkScheduleTypeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartmentGroup> DepartmentGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartmentJob> DepartmentJob { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartmentStaff> DepartmentStaff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartmentTargets> DepartmentTargets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartmentWorkSchedule> DepartmentWorkSchedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartmentWorkSchedule> DepartmentWorkSchedule1 { get; set; }

        public virtual DepartmentWorkSchedule DepartmentWorkSchedule2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeOrganizationalStructure> EmployeeOrganizationalStructure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeOrganizationalStructure> EmployeeOrganizationalStructure1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeOrganizationalStructure> EmployeeOrganizationalStructure2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeOrganizationalStructure> EmployeeOrganizationalStructure3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionPlan> BorderProtectionPlan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleHeader> BorderProtectionScheduleHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationalStructure> OrganizationalStructure1 { get; set; }

        public virtual OrganizationalStructure OrganizationalStructure2 { get; set; }

        public virtual OrganizationalStructureType OrganizationalStructureType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationalStructureChief> OrganizationalStructureChief { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportTemplate> ReportTemplate { get; set; }
    }
}
