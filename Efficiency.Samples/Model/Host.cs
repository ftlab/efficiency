namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Host")]
    public partial class Host
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal HostID { get; set; }

        [Required]
        [StringLength(100)]
        public string Family { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(30)]
        public string DocumentCod { get; set; }

        [Required]
        [StringLength(100)]
        public string DocumentNumber { get; set; }

        public DateTime? DocumentIssueDate { get; set; }

        [StringLength(100)]
        public string DocumentIssueOrganization { get; set; }
    }
}
