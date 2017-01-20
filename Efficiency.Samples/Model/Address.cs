namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("staffnotify.Address")]
    public partial class Address
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long QueueID { get; set; }

        [Key]
        [Column("Address", Order = 1)]
        [StringLength(50)]
        public string Address1 { get; set; }

        public bool IsSended { get; set; }

        public bool IsDelivered { get; set; }

        public virtual Queue Queue { get; set; }
    }
}
