namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.PlanType")]
    public partial class PlanType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlanType()
        {
            BorderProtectionPlan = new HashSet<BorderProtectionPlan>();
            BorderProtectionScheduleSectorDefaults = new HashSet<BorderProtectionScheduleSectorDefaults>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public long? DirectionId { get; set; }

        public virtual Direction Direction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionPlan> BorderProtectionPlan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleSectorDefaults> BorderProtectionScheduleSectorDefaults { get; set; }
    }
}
