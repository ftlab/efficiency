namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.DepartmentWorkSchedule")]
    public partial class DepartmentWorkSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DepartmentWorkSchedule()
        {
            BorderProtectionScheduleHeader = new HashSet<BorderProtectionScheduleHeader>();
            OrganizationalStructure2 = new HashSet<OrganizationalStructure>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public long DepartmentId { get; set; }

        public long? WorkScheduleTypeId { get; set; }

        public DateTime BeginDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public long? SubDepartmentId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleHeader> BorderProtectionScheduleHeader { get; set; }

        public virtual OrganizationalStructure OrganizationalStructure { get; set; }

        public virtual OrganizationalStructure OrganizationalStructure1 { get; set; }

        public virtual WorkScheduleType WorkScheduleType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationalStructure> OrganizationalStructure2 { get; set; }
    }
}
