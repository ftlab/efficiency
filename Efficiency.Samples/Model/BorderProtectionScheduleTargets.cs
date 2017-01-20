namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("planguard.BorderProtectionScheduleTargets")]
    public partial class BorderProtectionScheduleTargets
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long HeaderId { get; set; }

        public long? SectorId { get; set; }

        public long DepartmentJobId { get; set; }

        public int Count { get; set; }

        public virtual DepartmentJob DepartmentJob { get; set; }

        public virtual Sector Sector { get; set; }

        public virtual BorderProtectionScheduleHeader BorderProtectionScheduleHeader { get; set; }
    }
}
