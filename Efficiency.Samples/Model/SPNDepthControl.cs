namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.SPNDepthControl")]
    public partial class SPNDepthControl
    {
        public long ID { get; set; }

        public Guid AID { get; set; }

        public long Authorization_ID { get; set; }

        public long BorderCrossingID { get; set; }

        public long? UserInfoID { get; set; }

        public long? ArmId { get; set; }

        [StringLength(100)]
        public string ComputerName { get; set; }

        public long DecisionID { get; set; }

        public long? FaultTypeID { get; set; }

        public long? DecisionMakingUserID { get; set; }

        [StringLength(256)]
        public string FaultAdditional { get; set; }

        public string Reason { get; set; }

        public string Notes { get; set; }

        public virtual Authorization Authorization { get; set; }
    }
}
