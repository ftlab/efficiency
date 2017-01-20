namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VUserInfo_UI
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string LoginName { get; set; }

        [StringLength(100)]
        public string Family { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public DateTime? Birthday { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime RegistrationDate { get; set; }

        [StringLength(30)]
        public string StampNumber { get; set; }

        [StringLength(100)]
        public string Subdivision { get; set; }

        [StringLength(100)]
        public string Position { get; set; }

        public long? RankId { get; set; }

        [StringLength(100)]
        public string Rank { get; set; }
    }
}
