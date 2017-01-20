namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.ReportTemplate")]
    public partial class ReportTemplate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? DepartmentId { get; set; }

        public long? TypeId { get; set; }

        [Required]
        public byte[] Template { get; set; }

        public virtual OrganizationalStructure OrganizationalStructure { get; set; }

        public virtual ReportType ReportType { get; set; }
    }
}
