namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("infopas.FixedGroupLanguage")]
    public partial class FixedGroupLanguage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long GroupId { get; set; }

        public long LanguageId { get; set; }

        public virtual LanguageGroup LanguageGroup { get; set; }
    }
}
