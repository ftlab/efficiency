namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.MapObjects_Arm")]
    public partial class MapObjects_Arm
    {
        public int ID { get; set; }

        public long MapObjectId { get; set; }

        public long ArmId { get; set; }

        public virtual Arm1 Arm1 { get; set; }

        public virtual MapObjects MapObjects { get; set; }
    }
}
