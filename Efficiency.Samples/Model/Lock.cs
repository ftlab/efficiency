namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.Lock")]
    public partial class Lock
    {
        public long ID { get; set; }

        public Guid AID { get; set; }

        public long Authorization_ID { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Changed { get; set; }

        public DateTime? LockPC { get; set; }

        public DateTime? UnlockPC { get; set; }

        [StringLength(50)]
        public string CompName { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public virtual Authorization Authorization { get; set; }
    }
}
