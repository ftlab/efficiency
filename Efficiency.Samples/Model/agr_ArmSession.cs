namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.agr_ArmSession")]
    public partial class agr_ArmSession
    {
        [Key]
        [StringLength(256)]
        public string ArmName { get; set; }

        public DateTime StartDate { get; set; }

        public long? ArmId { get; set; }

        public long? EmployeeId { get; set; }

        [StringLength(100)]
        public string FamilyName { get; set; }

        [StringLength(100)]
        public string KaskadLoginName { get; set; }

        [StringLength(50)]
        public string WindowsLoginName { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime? LastPingDate { get; set; }

        [StringLength(50)]
        public string ТуреPing { get; set; }

        public long? PingID { get; set; }

        public short CountRegistration { get; set; }

        public short? AVG_TimeRegistration { get; set; }

        public long? BorderProtectionScheduleSectorID { get; set; }

        public virtual Arm1 Arm1 { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual BorderProtectionScheduleSector BorderProtectionScheduleSector { get; set; }
    }
}
