namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("param.ArmType_Dashboard_Configuration")]
    public partial class ArmType_Dashboard_Configuration
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ArmType_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Dashboard_Configuration_ID { get; set; }

        public bool IsDefault { get; set; }

        public virtual ArmType ArmType { get; set; }

        public virtual Dashboard_Configuration Dashboard_Configuration { get; set; }
    }
}
