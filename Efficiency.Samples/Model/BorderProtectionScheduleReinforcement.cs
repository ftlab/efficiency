namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.BorderProtectionScheduleReinforcement")]
    public partial class BorderProtectionScheduleReinforcement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long HeaderIdFrom { get; set; }

        public long? HeaderIdTo { get; set; }

        public long? SectorIdFrom { get; set; }

        public long? SectorIdTo { get; set; }

        public long EmployeeId { get; set; }

        public long Status { get; set; }

        public DateTime? BeginDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public DateTime? SendDateTime { get; set; }

        public DateTime? ReturnDateTime { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Sector Sector { get; set; }

        public virtual Sector Sector1 { get; set; }

        public virtual BorderProtectionScheduleHeader BorderProtectionScheduleHeader { get; set; }

        public virtual BorderProtectionScheduleHeader BorderProtectionScheduleHeader1 { get; set; }

        public virtual ReinforcementStatus ReinforcementStatus { get; set; }
    }
}
