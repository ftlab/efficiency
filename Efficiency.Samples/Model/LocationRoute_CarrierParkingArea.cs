namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.LocationRoute_CarrierParkingArea")]
    public partial class LocationRoute_CarrierParkingArea
    {
        public long Id { get; set; }

        public long LocationRouteId { get; set; }

        public long CarrierParkingAreaId { get; set; }

        public virtual CarrierParkingArea CarrierParkingArea { get; set; }

        public virtual LocationRoute LocationRoute { get; set; }
    }
}
