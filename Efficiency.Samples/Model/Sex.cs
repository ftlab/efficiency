namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.Sex")]
    public partial class Sex
    {
        [StringLength(1)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
