namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.v_ResultControlLastChronoFull")]
    public partial class v_ResultControlLastChronoFull
    {
        public long? HeaderId { get; set; }

        public long? SectorId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EmployeeId { get; set; }

        public long? LastId { get; set; }

        public byte? HadLunch { get; set; }

        public int? WorkTime { get; set; }

        public int? RestTime { get; set; }

        public int? RestCount { get; set; }
    }
}
