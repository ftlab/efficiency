namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KSBinfo.Obj_PNET3_NC32K")]
    public partial class Obj_PNET3_NC32K
    {
        public long ID { get; set; }

        [Required]
        [StringLength(60)]
        public string Code { get; set; }

        [StringLength(60)]
        public string Name { get; set; }
    }
}
