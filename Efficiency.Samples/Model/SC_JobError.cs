namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.SC_JobError")]
    public partial class SC_JobError
    {
        public long ID { get; set; }

        public long SC_JobHistoryID { get; set; }

        [Required]
        public string Message { get; set; }

        public virtual SC_JobHistory SC_JobHistory { get; set; }
    }
}
