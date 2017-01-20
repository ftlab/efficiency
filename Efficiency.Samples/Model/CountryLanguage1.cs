namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.CountryLanguage")]
    public partial class CountryLanguage1
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long CountryId { get; set; }

        public long LanguageId { get; set; }

        public byte? Percent { get; set; }
    }
}
