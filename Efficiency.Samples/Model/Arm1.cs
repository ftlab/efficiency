namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.Arm")]
    public partial class Arm1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arm1()
        {
            agr_ArmSession = new HashSet<agr_ArmSession>();
            agr_ArmSessionHistory = new HashSet<agr_ArmSessionHistory>();
            MapObjects_Arm = new HashSet<MapObjects_Arm>();
            ArmHierarchy = new HashSet<ArmHierarchy>();
            ArmHierarchy1 = new HashSet<ArmHierarchy>();
            LocationRoute_Arm = new HashSet<LocationRoute_Arm>();
            arg_RegistrationEndReg = new HashSet<arg_RegistrationEndReg>();
            agr_RegistrationStartReg = new HashSet<agr_RegistrationStartReg>();
            Starting = new HashSet<Starting>();
            ArmConfig = new HashSet<ArmConfig>();
            ArmGroup = new HashSet<ArmGroup>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Hostname { get; set; }

        public int TypeId { get; set; }

        [StringLength(100)]
        public string DisplayName { get; set; }

        public bool IsDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agr_ArmSession> agr_ArmSession { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agr_ArmSessionHistory> agr_ArmSessionHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MapObjects_Arm> MapObjects_Arm { get; set; }

        public virtual ArmType ArmType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArmHierarchy> ArmHierarchy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArmHierarchy> ArmHierarchy1 { get; set; }

        public virtual ArmPtk ArmPtk { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationRoute_Arm> LocationRoute_Arm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arg_RegistrationEndReg> arg_RegistrationEndReg { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agr_RegistrationStartReg> agr_RegistrationStartReg { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Starting> Starting { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArmConfig> ArmConfig { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArmGroup> ArmGroup { get; set; }
    }
}
