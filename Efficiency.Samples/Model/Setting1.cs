namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("param.Setting")]
    public partial class Setting1
    {
        public int ID { get; set; }

        [Required]
        [StringLength(128)]
        public string Code { get; set; }

        [Required]
        [StringLength(255)]
        public string DataType { get; set; }

        [Required]
        public byte[] Value { get; set; }

        public string Description { get; set; }
    }
}
