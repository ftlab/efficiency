namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.CabinState")]
    public partial class CabinState
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CabinStateId { get; set; }

        public long CabinId { get; set; }

        public bool IsBroken { get; set; }

        public DateTime LastChangeDateTime { get; set; }

        public virtual Cabin Cabin { get; set; }
    }
}
