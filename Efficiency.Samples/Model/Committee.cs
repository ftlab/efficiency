namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Committee")]
    public partial class Committee
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal CommitteeTypeID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal CommitteeID { get; set; }
    }
}
