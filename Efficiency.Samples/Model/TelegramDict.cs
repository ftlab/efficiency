namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelegramDict")]
    public partial class TelegramDict
    {
        [Column(TypeName = "numeric")]
        public decimal TelegramDictID { get; set; }

        [Required]
        [StringLength(100)]
        public string TelegramDictName { get; set; }

        [Required]
        [StringLength(100)]
        public string PAKDictName { get; set; }

        [StringLength(255)]
        public string EqualityClause { get; set; }

        [StringLength(100)]
        public string DescNumberValue1 { get; set; }

        [StringLength(100)]
        public string DescNumberValue2 { get; set; }

        [StringLength(100)]
        public string DescNumberValue3 { get; set; }

        [StringLength(100)]
        public string DescStringValue1 { get; set; }

        [StringLength(100)]
        public string DescStringValue2 { get; set; }

        [StringLength(100)]
        public string DescStringValue3 { get; set; }

        [StringLength(100)]
        public string DescDateValue1 { get; set; }

        [StringLength(100)]
        public string DescDateValue2 { get; set; }

        [StringLength(100)]
        public string DescDateValue3 { get; set; }
    }
}
