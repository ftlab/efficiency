namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.Maps")]
    public partial class Maps
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        public long LevelNumber { get; set; }

        public long? SectorId { get; set; }

        [Required]
        [StringLength(128)]
        public string Image { get; set; }

        public double ZeroX { get; set; }

        public double ZeroY { get; set; }

        public double Scale { get; set; }
    }
}
