namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("staffnotify.PresentationControlRecipient")]
    public partial class PresentationControlRecipient
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PresentationControlID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ArmName { get; set; }

        public long? UserID { get; set; }
    }
}
