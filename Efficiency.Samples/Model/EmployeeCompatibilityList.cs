namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.EmployeeCompatibilityList")]
    public partial class EmployeeCompatibilityList
    {
        public long Id { get; set; }

        public long EmployeeId { get; set; }

        public int CompatibilityTypeId { get; set; }

        public long ToEmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Employee Employee1 { get; set; }
    }
}
