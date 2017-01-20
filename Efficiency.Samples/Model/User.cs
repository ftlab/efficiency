namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sid { get; set; }

        [StringLength(126)]
        public string Family { get; set; }

        [StringLength(126)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Contour { get; set; }
    }
}
