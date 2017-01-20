namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.ChangeDirection")]
    public partial class ChangeDirection
    {
        public long ID { get; set; }

        public Guid AID { get; set; }

        public long Authorization_ID { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Changed { get; set; }

        [Column("ChangeDirection")]
        public DateTime? ChangeDirection1 { get; set; }

        public virtual Authorization Authorization { get; set; }
    }
}
