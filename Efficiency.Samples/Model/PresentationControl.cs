namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("staffnotify.PresentationControl")]
    public partial class PresentationControl
    {
        public int ID { get; set; }

        public DateTime Created { get; set; }

        public DateTime TTL { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        public string FileName { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string Data { get; set; }
    }
}
