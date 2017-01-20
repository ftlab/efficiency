namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("planguard.BorderProtectionScheduleReserve")]
    public partial class BorderProtectionScheduleReserve
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long HeaderId { get; set; }

        public long DepartmentJobId { get; set; }

        public virtual DepartmentJob DepartmentJob { get; set; }

        public virtual BorderProtectionScheduleHeader BorderProtectionScheduleHeader { get; set; }
    }
}
