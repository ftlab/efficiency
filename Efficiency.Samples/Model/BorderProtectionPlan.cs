namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("planguard.BorderProtectionPlan")]
    public partial class BorderProtectionPlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BorderProtectionPlan()
        {
            BorderProtectionScheduleHeader = new HashSet<BorderProtectionScheduleHeader>();
        }

        public long Id { get; set; }

        public long DepartmentId { get; set; }

        public DateTime BeginDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public bool IsCopied { get; set; }

        public long PlanTypeId { get; set; }

        public virtual OrganizationalStructure OrganizationalStructure { get; set; }

        public virtual PlanType PlanType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleHeader> BorderProtectionScheduleHeader { get; set; }
    }
}
