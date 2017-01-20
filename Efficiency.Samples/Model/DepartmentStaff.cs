namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.DepartmentStaff")]
    public partial class DepartmentStaff
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long DepartmentId { get; set; }

        public int OfficerCount { get; set; }

        public int EnsignCount { get; set; }

        public int SergeantCount { get; set; }

        public virtual OrganizationalStructure OrganizationalStructure { get; set; }
    }
}
