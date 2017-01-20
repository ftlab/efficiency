namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("infopas.LanguageGroupCabin")]
    public partial class LanguageGroupCabin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long LanguageGroupCabinId { get; set; }

        public long? LanguageGroupCabinPresetId { get; set; }

        public long CabinId { get; set; }

        public long? LanguageGroupId { get; set; }

        public virtual Cabin Cabin { get; set; }

        public virtual LanguageGroup LanguageGroup { get; set; }

        public virtual LanguageGroupCabinPreset LanguageGroupCabinPreset { get; set; }
    }
}
