namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.Sector")]
    public partial class Sector
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sector()
        {
            AirportSector = new HashSet<AirportSector>();
            ArmPtk = new HashSet<ArmPtk>();
            Cabin = new HashSet<Cabin>();
            ControlledPersonLocation = new HashSet<ControlledPersonLocation>();
            LocationRoute = new HashSet<LocationRoute>();
            LocationSector = new HashSet<LocationSector>();
            MapObjects_Sector = new HashSet<MapObjects_Sector>();
            BorderProtectionScheduleChronometry = new HashSet<BorderProtectionScheduleChronometry>();
            BorderProtectionScheduleDetail = new HashSet<BorderProtectionScheduleDetail>();
            BorderProtectionScheduleReinforcement = new HashSet<BorderProtectionScheduleReinforcement>();
            BorderProtectionScheduleReinforcement1 = new HashSet<BorderProtectionScheduleReinforcement>();
            BorderProtectionScheduleSector = new HashSet<BorderProtectionScheduleSector>();
            BorderProtectionScheduleSectorDefaults = new HashSet<BorderProtectionScheduleSectorDefaults>();
            BorderProtectionScheduleTargets = new HashSet<BorderProtectionScheduleTargets>();
            EmergencySector = new HashSet<EmergencySector>();
            RegimeActivity = new HashSet<RegimeActivity>();
            arg_RegistrationEndReg = new HashSet<arg_RegistrationEndReg>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long DirectionId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public byte Difficulty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AirportSector> AirportSector { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArmPtk> ArmPtk { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cabin> Cabin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlledPersonLocation> ControlledPersonLocation { get; set; }

        public virtual Direction Direction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationRoute> LocationRoute { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationSector> LocationSector { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MapObjects_Sector> MapObjects_Sector { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleChronometry> BorderProtectionScheduleChronometry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleDetail> BorderProtectionScheduleDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleReinforcement> BorderProtectionScheduleReinforcement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleReinforcement> BorderProtectionScheduleReinforcement1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleSector> BorderProtectionScheduleSector { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleSectorDefaults> BorderProtectionScheduleSectorDefaults { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorderProtectionScheduleTargets> BorderProtectionScheduleTargets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmergencySector> EmergencySector { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegimeActivity> RegimeActivity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arg_RegistrationEndReg> arg_RegistrationEndReg { get; set; }
    }
}
