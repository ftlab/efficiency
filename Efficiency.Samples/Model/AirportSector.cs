namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.AirportSector")]
    public partial class AirportSector
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long SectorID { get; set; }

        [Required]
        [StringLength(128)]
        public string AirportName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Probability { get; set; }

        public virtual Sector Sector { get; set; }
    }
}
