namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.EventPTKLogAttachment")]
    public partial class EventPTKLogAttachment
    {
        public long ID { get; set; }

        public long AttachmentTypeID { get; set; }

        public long EventLogID { get; set; }

        public long EmployeeID { get; set; }

        public DateTime CreateDate { get; set; }

        public bool isDeleted { get; set; }

        public long LogPTKFileID { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual AttachmentType AttachmentType { get; set; }

        public virtual EventLog EventLog { get; set; }
    }
}
