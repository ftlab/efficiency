namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.Resemblance_Forpost2Result")]
    public partial class Resemblance_Forpost2Result
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ResemblanceID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Forpost2Id { get; set; }

        public double Weight { get; set; }

        public int ErrorCount { get; set; }

        public virtual Resemblance Resemblance { get; set; }
    }
}
