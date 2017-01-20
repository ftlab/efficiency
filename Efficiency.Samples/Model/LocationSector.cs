namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.LocationSector")]
    public partial class LocationSector
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long LocationId { get; set; }

        public long SectorId { get; set; }

        public int? MaximumPeriod { get; set; }

        public virtual Location Location { get; set; }

        public virtual Sector Sector { get; set; }
    }
}
