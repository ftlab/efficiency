namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        [Column(TypeName = "numeric")]
        public decimal CountryID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string ICAOCod { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EmigrantFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DeleteFlag { get; set; }

        [Column("_TelegramFlag")]
        public int? C_TelegramFlag { get; set; }

        [Required]
        [StringLength(100)]
        public string ShortName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ReadOnly { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MigrationCardFlag { get; set; }

        public Guid? rowguid { get; set; }
    }
}
