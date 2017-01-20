namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("staffnotify.InformJournalRecipient")]
    public partial class InformJournalRecipient
    {
        public long ID { get; set; }

        public long InformJournalID { get; set; }

        [Required]
        [StringLength(50)]
        public string ArmName { get; set; }

        public long? UserID { get; set; }

        public bool IsDelivered { get; set; }

        public bool IsReaded { get; set; }
    }
}
