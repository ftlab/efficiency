namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.OrganizationalStructureChief")]
    public partial class OrganizationalStructureChief
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long OrganizationalStructureId { get; set; }

        public long TypeId { get; set; }

        [Required]
        [StringLength(300)]
        public string Post { get; set; }

        public long EmployeeId { get; set; }

        public virtual ChiefType ChiefType { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual OrganizationalStructure OrganizationalStructure { get; set; }
    }
}
