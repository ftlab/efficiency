namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("planguard.BorderProtectionScheduleSectorDefaults")]
    public partial class BorderProtectionScheduleSectorDefaults
    {
        public long Id { get; set; }

        public long PlanTypeId { get; set; }

        public long SectorId { get; set; }

        public virtual PlanType PlanType { get; set; }

        public virtual Sector Sector { get; set; }
    }
}
