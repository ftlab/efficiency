namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resultguard.ControlledPersonStatus")]
    public partial class ControlledPersonStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ControlledPersonStatusID { get; set; }

        [StringLength(50)]
        public string ControlledPersonStatusName { get; set; }
    }
}
