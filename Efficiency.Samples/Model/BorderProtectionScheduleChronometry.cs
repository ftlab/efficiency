namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.BorderProtectionScheduleChronometry")]
    public partial class BorderProtectionScheduleChronometry
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? HeaderId { get; set; }

        public long EmployeeId { get; set; }

        public long LocationId { get; set; }

        public long? SectorId { get; set; }

        public long? DepartmentJobId { get; set; }

        public long? DepartmentGroupId { get; set; }

        public DateTime BeginDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public long? ArmId { get; set; }

        public long? SessionId { get; set; }

        public bool? LunchTime { get; set; }

        public long? LocationRouteId { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public virtual ArmPtk ArmPtk { get; set; }

        public virtual DepartmentGroup DepartmentGroup { get; set; }

        public virtual DepartmentJob DepartmentJob { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Location Location { get; set; }

        public virtual LocationRoute LocationRoute { get; set; }

        public virtual Sector Sector { get; set; }

        public virtual BorderProtectionScheduleHeader BorderProtectionScheduleHeader { get; set; }
    }
}
