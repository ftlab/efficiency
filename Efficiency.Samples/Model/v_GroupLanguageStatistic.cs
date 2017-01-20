namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("infopas.v_GroupLanguageStatistic")]
    public partial class v_GroupLanguageStatistic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long LanguageGroupId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public long? TemplatePadS4Id { get; set; }

        public long? Language1 { get; set; }

        public long? Language2 { get; set; }

        public long? Language3 { get; set; }
    }
}
