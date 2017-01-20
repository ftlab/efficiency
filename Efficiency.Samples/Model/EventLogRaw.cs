namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.EventLogRaw")]
    public partial class EventLogRaw
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventLogRaw()
        {
            EventLog = new HashSet<EventLog>();
        }

        public long ID { get; set; }

        public short EventTypeID { get; set; }

        public short PriorityID { get; set; }

        public DateTime EventDate { get; set; }

        public long? MapObjectID { get; set; }

        public long? PassengerID { get; set; }

        public long? EmployeeID { get; set; }

        public long? KSBEventID { get; set; }

        public long? ParentEventLogID { get; set; }

        public long? ControlID { get; set; }

        public virtual ControlRequest ControlRequest { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual MapObjects MapObjects { get; set; }

        public virtual Protocol Protocol { get; set; }

        public virtual EventRawType EventRawType { get; set; }

        public virtual EventPriority EventPriority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLog> EventLog { get; set; }
    }
}
