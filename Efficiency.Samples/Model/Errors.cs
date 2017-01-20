namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.Errors")]
    public partial class Errors
    {
        public long ID { get; set; }

        public Guid AID { get; set; }

        public long Starting_ID { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Changed { get; set; }

        [Required]
        [StringLength(2056)]
        public string ErrorText { get; set; }

        public virtual Starting Starting { get; set; }
    }
}
