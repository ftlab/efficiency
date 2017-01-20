namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.EmployeeOrganizationalStructure")]
    public partial class EmployeeOrganizationalStructure
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? BrigadeId { get; set; }

        public long? ArrivalStationId { get; set; }

        public long? DepartmentId { get; set; }

        public long? GangId { get; set; }

        public long EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual OrganizationalStructure OrganizationalStructure { get; set; }

        public virtual OrganizationalStructure OrganizationalStructure1 { get; set; }

        public virtual OrganizationalStructure OrganizationalStructure2 { get; set; }

        public virtual OrganizationalStructure OrganizationalStructure3 { get; set; }
    }
}
