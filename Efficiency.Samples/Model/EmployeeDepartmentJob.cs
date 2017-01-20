namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.EmployeeDepartmentJob")]
    public partial class EmployeeDepartmentJob
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long DepartmentJobId { get; set; }

        public long EmployeeId { get; set; }

        [StringLength(500)]
        public string Reason { get; set; }

        public byte? Experience { get; set; }

        public virtual DepartmentJob DepartmentJob { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
