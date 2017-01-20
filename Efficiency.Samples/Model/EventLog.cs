namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.EventLog")]
    public partial class EventLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventLog()
        {
            RegimeActivity = new HashSet<RegimeActivity>();
            CustomEventProperties = new HashSet<CustomEventProperties>();
            EventPhotoAttachments = new HashSet<EventPhotoAttachments>();
            EventPTKLogAttachment = new HashSet<EventPTKLogAttachment>();
            EventVideoAttachment = new HashSet<EventVideoAttachment>();
            Employee1 = new HashSet<Employee>();
            Protocol1 = new HashSet<Protocol>();
            EventLogRaw = new HashSet<EventLogRaw>();
            MapObjects1 = new HashSet<MapObjects>();
            Passenger1 = new HashSet<Passenger>();
        }

        public long Id { get; set; }

        public short EventTypeId { get; set; }

        public short PriorityId { get; set; }

        public DateTime EventDate { get; set; }

        public bool isCustomEvent { get; set; }

        public bool IsDeleted { get; set; }

        public long? MapObjectID { get; set; }

        public long? PassengerID { get; set; }

        public long? EmployeeID { get; set; }

        public long? KSBEventID { get; set; }

        public long? ParentEventLogID { get; set; }

        public string Description { get; set; }

        public long? ControlID { get; set; }

        public virtual ControlRequest ControlRequest { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual MapObjects MapObjects { get; set; }

        public virtual Protocol Protocol { get; set; }

        public virtual Passenger Passenger { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegimeActivity> RegimeActivity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomEventProperties> CustomEventProperties { get; set; }

        public virtual EventType EventType { get; set; }

        public virtual EventPriority EventPriority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventPhotoAttachments> EventPhotoAttachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventPTKLogAttachment> EventPTKLogAttachment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventVideoAttachment> EventVideoAttachment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Protocol> Protocol1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLogRaw> EventLogRaw { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MapObjects> MapObjects1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passenger> Passenger1 { get; set; }
    }
}
