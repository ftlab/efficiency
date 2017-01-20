namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KSBvideo.RequestVideoFile")]
    public partial class RequestVideoFile
    {
        public long ID { get; set; }

        public Guid RequestID { get; set; }

        [Required]
        [StringLength(100)]
        public string CamID { get; set; }

        public bool ExistAudio { get; set; }

        public DateTime StartVideoTime { get; set; }

        public DateTime EndVideoTime { get; set; }

        public int TimeOut { get; set; }

        public DateTime StartRequestTime { get; set; }

        public DateTime? EndRequestTime { get; set; }

        public int? ReturnCode { get; set; }

        [StringLength(250)]
        public string FileName { get; set; }

        [StringLength(1024)]
        public string Comment { get; set; }
    }
}
