namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.LocationRoute")]
    public partial class LocationRoute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LocationRoute()
        {
            DutyRoutes = new HashSet<DutyRoutes>();
            BorderProtectionScheduleChronometry = new HashSet<BorderProtectionScheduleChronometry>();
            BorderProtectionScheduleDetail = new HashSet<BorderProtectionScheduleDetail>();
            LocationRoute_Arm = new HashSet<LocationRoute_Arm>();
            LocationRoute_CarrierParkingArea = new HashSet<LocationRoute_CarrierParkingArea>();
            LocationRoute_MapObjects = new HashSet<LocationRoute_MapObjects>();
        }

        public long Id { get; set; }

        public long LocationId { get; set; }

        public long SectorId { get; set; }

        [Required]
        [StringLength(25)]
        public string RouteName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DutyRoutes> DutyRoutes { get; set; }

        public virtual Location Location { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleChronometry> BorderProtectionScheduleChronometry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleDetail> BorderProtectionScheduleDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationRoute_Arm> LocationRoute_Arm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationRoute_CarrierParkingArea> LocationRoute_CarrierParkingArea { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationRoute_MapObjects> LocationRoute_MapObjects { get; set; }

        public virtual Sector Sector { get; set; }
    }
}
