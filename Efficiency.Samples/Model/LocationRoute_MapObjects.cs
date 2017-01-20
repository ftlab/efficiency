namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.LocationRoute_MapObjects")]
    public partial class LocationRoute_MapObjects
    {
        public long Id { get; set; }

        public long MapObjectId { get; set; }

        public long LocationRouteId { get; set; }

        public virtual LocationRoute LocationRoute { get; set; }

        public virtual MapObjects MapObjects { get; set; }
    }
}
