namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.Cabin")]
    public partial class Cabin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cabin()
        {
            MapObjects_Cabin = new HashSet<MapObjects_Cabin>();
            CabinState = new HashSet<CabinState>();
            LanguageGroupCabin = new HashSet<LanguageGroupCabin>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long SectorId { get; set; }

        [StringLength(50)]
        public string CabinNumber { get; set; }

        public long? LeftArmId { get; set; }

        public long? RightArmId { get; set; }

        public virtual ArmPtk ArmPtk { get; set; }

        public virtual ArmPtk ArmPtk1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MapObjects_Cabin> MapObjects_Cabin { get; set; }

        public virtual Sector Sector { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CabinState> CabinState { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LanguageGroupCabin> LanguageGroupCabin { get; set; }
    }
}
