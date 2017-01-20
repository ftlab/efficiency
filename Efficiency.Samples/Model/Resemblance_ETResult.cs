namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.Resemblance_ETResult")]
    public partial class Resemblance_ETResult
    {
        public long Id { get; set; }

        public long ResemblanceId { get; set; }

        public long RevealId { get; set; }

        public long? BorderCrossingPhotoId { get; set; }

        public long? BorderCrossingId { get; set; }

        public long? OperationId { get; set; }

        public bool IsAlien { get; set; }

        [StringLength(50)]
        public string Note { get; set; }

        [StringLength(50)]
        public string Checked { get; set; }

        public DateTime? CheckResultDate { get; set; }

        public virtual Resemblance Resemblance { get; set; }

        public virtual Reveal Reveal { get; set; }
    }
}
