namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("param.Numeric")]
    public partial class Numeric
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }
    }
}
