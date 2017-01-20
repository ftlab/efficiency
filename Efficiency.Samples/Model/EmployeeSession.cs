namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.EmployeeSession")]
    public partial class EmployeeSession
    {
        [Key]
        [StringLength(100)]
        public string ArmHostName { get; set; }

        public long EmployeeID { get; set; }

        public DateTime LoginTime { get; set; }
    }
}
