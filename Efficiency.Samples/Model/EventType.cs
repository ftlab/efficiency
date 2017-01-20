namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.EventType")]
    public partial class EventType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventType()
        {
            EventLog = new HashSet<EventLog>();
            EventRawType__EventType = new HashSet<EventRawType__EventType>();
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

        public int? DefaultDuration { get; set; }

        public bool IsSystem { get; set; }

        public bool IsDeleted { get; set; }

        public virtual EventGroup EventGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLog> EventLog { get; set; }

        public virtual EventPriority EventPriority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventRawType__EventType> EventRawType__EventType { get; set; }
    }
}
