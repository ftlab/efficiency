namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.EventRawType")]
    public partial class EventRawType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventRawType()
        {
            ActivityMode = new HashSet<ActivityMode>();
            ActivityMode1 = new HashSet<ActivityMode>();
            EventLogRaw = new HashSet<EventLogRaw>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ID { get; set; }

        public short EventGroupID { get; set; }

        public short DefaultPriorityID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public bool IsSystem { get; set; }

        public bool IsDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityMode> ActivityMode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityMode> ActivityMode1 { get; set; }

        public virtual EventGroup EventGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLogRaw> EventLogRaw { get; set; }

        public virtual EventPriority EventPriority { get; set; }

        public virtual EventRawType__EventType EventRawType__EventType { get; set; }
    }
}
