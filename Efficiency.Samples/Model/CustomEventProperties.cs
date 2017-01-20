namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.CustomEventProperties")]
    public partial class CustomEventProperties
    {
        public long Id { get; set; }

        public long EventLogId { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomEventName { get; set; }

        [StringLength(1000)]
        public string Comment { get; set; }

        public long AuthorId { get; set; }

        public DateTime CreateDate { get; set; }

        public bool IsTracked { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual EventLog EventLog { get; set; }
    }
}
