namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.DutyRoutes")]
    public partial class DutyRoutes
    {
        public long Id { get; set; }

        public long LocationRouteId { get; set; }

        public long DutyTypeId { get; set; }

        public bool IsDefaultPlanValue { get; set; }

        public bool IsDeleted { get; set; }

        public virtual DutyType DutyType { get; set; }

        public virtual LocationRoute LocationRoute { get; set; }
    }
}
