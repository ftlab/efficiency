namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.ArmHierarchy")]
    public partial class ArmHierarchy
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long ParentArmId { get; set; }

        public long ChildArmId { get; set; }

        public virtual Arm1 Arm1 { get; set; }

        public virtual Arm1 Arm11 { get; set; }
    }
}
