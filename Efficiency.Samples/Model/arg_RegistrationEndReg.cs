namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.arg_RegistrationEndReg")]
    public partial class arg_RegistrationEndReg
    {
        public long ID { get; set; }

        public long SectorId { get; set; }

        public long ArmId { get; set; }

        public DateTime StartReg { get; set; }

        public DateTime EndReg { get; set; }

        public bool RUS_Passenger { get; set; }

        public virtual Arm1 Arm1 { get; set; }

        public virtual Sector Sector { get; set; }
    }
}
