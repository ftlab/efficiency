namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("planguard.BorderProtectionScheduleDetail")]
    public partial class BorderProtectionScheduleDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long HeaderId { get; set; }

        public long EmployeeId { get; set; }

        public long? SectorId { get; set; }

        public long? DepartmentJobId { get; set; }

        public bool? EmployeeIsChief { get; set; }

        public long? DeparmtentGroupId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime? LunchPlanedTime { get; set; }

        public bool IsManual { get; set; }

        public DateTime? BeginDate { get; set; }

        public DateTime? EndDate { get; set; }

        public long? EmployeeActivityTypeId { get; set; }

        public int? ReservNumber { get; set; }

        public long? EmployeeWorkPermitScheduleID { get; set; }

        public long? LocationRouteId { get; set; }

        public virtual DepartmentGroup DepartmentGroup { get; set; }

        public virtual DepartmentJob DepartmentJob { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual EmployeeActivityType EmployeeActivityType { get; set; }

        public virtual EmployeeWorkPermitSchedule EmployeeWorkPermitSchedule { get; set; }

        public virtual LocationRoute LocationRoute { get; set; }

        public virtual Sector Sector { get; set; }

        public virtual BorderProtectionScheduleHeader BorderProtectionScheduleHeader { get; set; }
    }
}
