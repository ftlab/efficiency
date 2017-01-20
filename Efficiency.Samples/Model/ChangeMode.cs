namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.ChangeMode")]
    public partial class ChangeMode
    {
        public long ID { get; set; }

        public Guid AID { get; set; }

        public long Authorization_ID { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Changed { get; set; }

        [Column("ChangeMode")]
        public DateTime? ChangeMode1 { get; set; }

        public virtual Authorization Authorization { get; set; }
    }
}
