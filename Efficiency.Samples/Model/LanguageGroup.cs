namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("infopas.LanguageGroup")]
    public partial class LanguageGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LanguageGroup()
        {
            FixedGroupLanguage = new HashSet<FixedGroupLanguage>();
            LanguageGroupCabin = new HashSet<LanguageGroupCabin>();
            ValidGroupLanguage = new HashSet<ValidGroupLanguage>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long LanguageGroupId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public long? TemplatePadS4Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FixedGroupLanguage> FixedGroupLanguage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LanguageGroupCabin> LanguageGroupCabin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValidGroupLanguage> ValidGroupLanguage { get; set; }
    }
}
