namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.MapObjects_Sector")]
    public partial class MapObjects_Sector
    {
        public int ID { get; set; }

        public long MapObjectId { get; set; }

        public long SectorId { get; set; }

        public virtual MapObjects MapObjects { get; set; }

        public virtual Sector Sector { get; set; }
    }
}
