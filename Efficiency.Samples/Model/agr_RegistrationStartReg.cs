namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.agr_RegistrationStartReg")]
    public partial class agr_RegistrationStartReg
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ArmID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime StartReg { get; set; }

        public virtual Arm1 Arm1 { get; set; }
    }
}
