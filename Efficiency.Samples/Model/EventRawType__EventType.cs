namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.EventRawType__EventType")]
    public partial class EventRawType__EventType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short EventRawTypeID { get; set; }

        public short? EventTypeID { get; set; }

        [StringLength(128)]
        public string EventTypeSetProc { get; set; }

        public virtual EventRawType EventRawType { get; set; }

        public virtual EventType EventType { get; set; }
    }
}
