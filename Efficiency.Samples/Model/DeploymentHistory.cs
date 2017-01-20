namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("param.DeploymentHistory")]
    public partial class DeploymentHistory
    {
        public long Id { get; set; }

        public DateTime? DateTime { get; set; }

        [StringLength(255)]
        public string HOST_NAME { get; set; }

        [StringLength(255)]
        public string SYSTEM_USER { get; set; }

        [StringLength(255)]
        public string ORIGINAL_LOGIN { get; set; }

        [StringLength(255)]
        public string SUSER_SNAME { get; set; }
    }
}
