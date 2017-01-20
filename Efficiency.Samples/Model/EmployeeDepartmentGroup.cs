namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.EmployeeDepartmentGroup")]
    public partial class EmployeeDepartmentGroup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long DepartmentGroupId { get; set; }

        public long EmployeeId { get; set; }

        [StringLength(500)]
        public string Reason { get; set; }

        public virtual DepartmentGroup DepartmentGroup { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
