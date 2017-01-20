namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.Setting")]
    public partial class Setting
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte[] Value { get; set; }
    }
}
