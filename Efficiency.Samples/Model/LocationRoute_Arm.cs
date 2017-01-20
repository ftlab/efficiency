namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.LocationRoute_Arm")]
    public partial class LocationRoute_Arm
    {
        public long Id { get; set; }

        public long LocationRouteId { get; set; }

        public long ArmId { get; set; }

        public virtual Arm1 Arm1 { get; set; }

        public virtual LocationRoute LocationRoute { get; set; }
    }
}
