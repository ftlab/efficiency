namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.RegimeActivity")]
    public partial class RegimeActivity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long ActivityModeTypeID { get; set; }

        public long LocationID { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime? DateEnd { get; set; }

        public byte Status { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        public long? EmployeeOpenId { get; set; }

        public long? EmployeeCloseId { get; set; }

        public byte[] Photo { get; set; }

        public long? EventLogId { get; set; }

        public long? ControlID { get; set; }

        public virtual ActivityMode ActivityMode { get; set; }

        public virtual Sector Sector { get; set; }

        public virtual EventLog EventLog { get; set; }
    }
}
