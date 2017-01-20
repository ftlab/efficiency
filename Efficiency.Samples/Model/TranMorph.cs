namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TranMorph")]
    public partial class TranMorph
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string Lng { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Lat { get; set; }

        [Required]
        [StringLength(100)]
        public string Rus { get; set; }
    }
}
