namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.MapObjects")]
    public partial class MapObjects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MapObjects()
        {
            LocationRoute_MapObjects = new HashSet<LocationRoute_MapObjects>();
            MapObjects_Camera = new HashSet<MapObjects_Camera>();
            MapObjects_Camera1 = new HashSet<MapObjects_Camera>();
            MapObjects_Arm = new HashSet<MapObjects_Arm>();
            MapObjects_Cabin = new HashSet<MapObjects_Cabin>();
            MapObjects_Sector = new HashSet<MapObjects_Sector>();
            EventLog = new HashSet<EventLog>();
            EventLogRaw = new HashSet<EventLogRaw>();
            EventVideoAttachment = new HashSet<EventVideoAttachment>();
            LastProhod = new HashSet<LastProhod>();
            MapObjectState = new HashSet<MapObjectState>();
            MapObjectStateEndTime = new HashSet<MapObjectStateEndTime>();
            MapObjectStateEventLogEndTime = new HashSet<MapObjectStateEventLogEndTime>();
            EventLog1 = new HashSet<EventLog>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public long ObjectTypeId { get; set; }

        public long? SectorId { get; set; }

        public long LevelNumber { get; set; }

        public double PositionX { get; set; }

        public double PositionY { get; set; }

        public double Rotation { get; set; }

        [StringLength(64)]
        public string ExternalName { get; set; }

        [StringLength(2048)]
        public string Properties { get; set; }

        [StringLength(1024)]
        public string URI { get; set; }

        public bool? IsDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationRoute_MapObjects> LocationRoute_MapObjects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MapObjects_Camera> MapObjects_Camera { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MapObjects_Camera> MapObjects_Camera1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MapObjects_Arm> MapObjects_Arm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MapObjects_Cabin> MapObjects_Cabin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MapObjects_Sector> MapObjects_Sector { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLog> EventLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLogRaw> EventLogRaw { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventVideoAttachment> EventVideoAttachment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LastProhod> LastProhod { get; set; }

        public virtual MapObjectTypes MapObjectTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MapObjectState> MapObjectState { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MapObjectStateEndTime> MapObjectStateEndTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MapObjectStateEventLogEndTime> MapObjectStateEventLogEndTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLog> EventLog1 { get; set; }
    }
}
