namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.EventVideoAttachment")]
    public partial class EventVideoAttachment
    {
        public long Id { get; set; }

        public long AttachmentTypeId { get; set; }

        public long EventLogId { get; set; }

        public long EmployeeId { get; set; }

        public DateTime CreateDate { get; set; }

        public bool isDeleted { get; set; }

        public long MapObjectId { get; set; }

        public Guid RequestId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual MapObjects MapObjects { get; set; }

        public virtual AttachmentType AttachmentType { get; set; }

        public virtual EventLog EventLog { get; set; }
    }
}
