namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.PakLogFile")]
    public partial class PakLogFile
    {
        public long ID { get; set; }

        public long Starting_ID { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        [Required]
        [StringLength(256)]
        public string PTKFileName { get; set; }

        [Required]
        [StringLength(256)]
        public string CMIORFileName { get; set; }

        public virtual Starting Starting { get; set; }
    }
}
