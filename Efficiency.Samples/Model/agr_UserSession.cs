namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.agr_UserSession")]
    public partial class agr_UserSession
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ArmID { get; set; }

        public long Authorization_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        public DateTime LoginTime { get; set; }
    }
}
