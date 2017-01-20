namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stat.v_EventVideoAttachment")]
    public partial class v_EventVideoAttachment
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long AttachmentTypeId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EventLogId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EmployeeId { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime CreateDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool isDeleted { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MapObjectId { get; set; }

        [Key]
        [Column(Order = 7)]
        public Guid RequestId { get; set; }

        [StringLength(250)]
        public string FileName { get; set; }

        public bool? LoadedStatus { get; set; }
    }
}
