namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.Employee__Statistic_Control")]
    public partial class Employee__Statistic_Control
    {
        public int ID { get; set; }

        public long EmployeeID { get; set; }

        public int Statistic_Control_ID { get; set; }

        public int? Employee_ReportGroupID { get; set; }

        [Column(TypeName = "xml")]
        public string DefaultParams { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Statistic_Control Statistic_Control { get; set; }

        public virtual Employee_ReportGroup Employee_ReportGroup { get; set; }
    }
}
