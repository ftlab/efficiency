namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ADP_Fine
    {
        public DateTime? ExecutionDate { get; set; }

        [StringLength(100)]
        public string TicketNumber { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal AdministrativeCaseID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Amount { get; set; }
    }
}
