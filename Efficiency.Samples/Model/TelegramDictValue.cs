namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TelegramDictValue")]
    public partial class TelegramDictValue
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal TelegramDictID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal TelegramDictValueID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NumberValue1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NumberValue2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NumberValue3 { get; set; }

        [StringLength(255)]
        public string StringValue1 { get; set; }

        [StringLength(255)]
        public string StringValue2 { get; set; }

        [StringLength(255)]
        public string StringValue3 { get; set; }

        public DateTime? DateValue1 { get; set; }

        public DateTime? DateValue2 { get; set; }

        public DateTime? DateValue3 { get; set; }
    }
}
