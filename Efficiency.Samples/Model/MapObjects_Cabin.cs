namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.MapObjects_Cabin")]
    public partial class MapObjects_Cabin
    {
        public int ID { get; set; }

        public long MapObjectId { get; set; }

        public long CabinId { get; set; }

        public virtual Cabin Cabin { get; set; }

        public virtual MapObjects MapObjects { get; set; }
    }
}
