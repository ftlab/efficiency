namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("staffnotify.InformJournal")]
    public partial class InformJournal
    {
        public long ID { get; set; }

        public DateTime Created { get; set; }

        public long SenderID { get; set; }

        [StringLength(50)]
        public string SenderName { get; set; }

        public bool IsPTK { get; set; }

        public bool IsSenderPTK { get; set; }

        public bool? RequireProof { get; set; }

        public DateTime TTL { get; set; }

        [Required]
        [StringLength(50)]
        public string NotificationType { get; set; }

        [StringLength(1024)]
        public string Message { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string Body { get; set; }

        public long ADmask { get; set; }

        public long? EventLogID { get; set; }
    }
}
