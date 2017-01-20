namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.MapObjectState")]
    public partial class MapObjectState
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MapObjectID { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool IsShadowType { get; set; }

        public short MapObjectStateTypeID { get; set; }

        public virtual MapObjects MapObjects { get; set; }

        public virtual MapObjectStateType MapObjectStateType { get; set; }
    }
}
