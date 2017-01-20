namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("planguard.BorderProtectionScheduleHeader")]
    public partial class BorderProtectionScheduleHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BorderProtectionScheduleHeader()
        {
            BorderProtectionScheduleDetail = new HashSet<BorderProtectionScheduleDetail>();
            BorderProtectionScheduleChronometry = new HashSet<BorderProtectionScheduleChronometry>();
            BorderProtectionScheduleReinforcement = new HashSet<BorderProtectionScheduleReinforcement>();
            BorderProtectionScheduleReinforcement1 = new HashSet<BorderProtectionScheduleReinforcement>();
            BorderProtectionScheduleReserve = new HashSet<BorderProtectionScheduleReserve>();
            BorderProtectionScheduleSector = new HashSet<BorderProtectionScheduleSector>();
            BorderProtectionScheduleTargets = new HashSet<BorderProtectionScheduleTargets>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long DepartmentId { get; set; }

        public long DepartmentWorkScheduleId { get; set; }

        public DateTime BeginDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public bool IsCopied { get; set; }

        public long? PlanId { get; set; }

        public virtual DepartmentWorkSchedule DepartmentWorkSchedule { get; set; }

        public virtual OrganizationalStructure OrganizationalStructure { get; set; }

        public virtual BorderProtectionPlan BorderProtectionPlan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleDetail> BorderProtectionScheduleDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleChronometry> BorderProtectionScheduleChronometry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleReinforcement> BorderProtectionScheduleReinforcement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleReinforcement> BorderProtectionScheduleReinforcement1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleReserve> BorderProtectionScheduleReserve { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleSector> BorderProtectionScheduleSector { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleTargets> BorderProtectionScheduleTargets { get; set; }
    }
}
