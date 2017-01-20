namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.MapObjects_Camera")]
    public partial class MapObjects_Camera
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MapObjectId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MapObjectId_Camera { get; set; }

        public bool IsPrimary { get; set; }

        public int TimeIntervalBefore { get; set; }

        public int TimeIntervalAfter { get; set; }

        public virtual MapObjects MapObjects { get; set; }

        public virtual MapObjects MapObjects1 { get; set; }
    }
}
