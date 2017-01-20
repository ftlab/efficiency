namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.DepartmentTargets")]
    public partial class DepartmentTargets
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long DepartmentId { get; set; }

        public long DepartmentJobId { get; set; }

        public int Count { get; set; }

        public virtual DepartmentJob DepartmentJob { get; set; }

        public virtual OrganizationalStructure OrganizationalStructure { get; set; }
    }
}
