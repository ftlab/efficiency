namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.MapObjectStateEndTime")]
    public partial class MapObjectStateEndTime
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MapObjectID { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool IsShadowType { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MapObjectStateTypeID { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime EndTime { get; set; }

        public virtual MapObjects MapObjects { get; set; }

        public virtual MapObjectStateType MapObjectStateType { get; set; }
    }
}
