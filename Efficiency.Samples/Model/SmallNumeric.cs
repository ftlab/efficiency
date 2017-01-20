namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("param.SmallNumeric")]
    public partial class SmallNumeric
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }
    }
}
