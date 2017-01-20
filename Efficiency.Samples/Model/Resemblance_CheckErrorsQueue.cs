namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.Resemblance_CheckErrorsQueue")]
    public partial class Resemblance_CheckErrorsQueue
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long FileId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CheckId { get; set; }

        [StringLength(2000)]
        public string Message { get; set; }

        public DateTime CheckDate { get; set; }
    }
}
