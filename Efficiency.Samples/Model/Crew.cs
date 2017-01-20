namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Crew")]
    public partial class Crew
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CarrierTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CrewTypeID { get; set; }
    }
}
