namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("infopas.EmergencySector")]
    public partial class EmergencySector
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long EmergencyId { get; set; }

        public long SectorId { get; set; }

        public virtual Sector Sector { get; set; }

        public virtual Emergency Emergency { get; set; }
    }
}
