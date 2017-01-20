namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.DocumentScan")]
    public partial class DocumentScan
    {
        public long ID { get; set; }

        public long ReadingID { get; set; }

        public short DocumentScanTypeID { get; set; }

        [StringLength(256)]
        public string CMIORFileName { get; set; }

        public byte[] ImageSource { get; set; }

        public virtual DocumentScanType DocumentScanType { get; set; }

        public virtual Reading Reading { get; set; }
    }
}
