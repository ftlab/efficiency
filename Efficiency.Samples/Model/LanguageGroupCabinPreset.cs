namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("infopas.LanguageGroupCabinPreset")]
    public partial class LanguageGroupCabinPreset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LanguageGroupCabinPreset()
        {
            LanguageGroupCabin = new HashSet<LanguageGroupCabin>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long LanguageGroupCabinPresetId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LanguageGroupCabin> LanguageGroupCabin { get; set; }
    }
}
