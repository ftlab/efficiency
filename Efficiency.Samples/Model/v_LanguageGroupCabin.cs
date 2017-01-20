namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("infopas.v_LanguageGroupCabin")]
    public partial class v_LanguageGroupCabin
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CabinId { get; set; }

        [StringLength(50)]
        public string CabinNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SectorId { get; set; }

        public long? GroupId { get; set; }

        public bool? LeftArm { get; set; }

        public bool? RightArm { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsBroken { get; set; }

        public long? PresetId { get; set; }
    }
}
