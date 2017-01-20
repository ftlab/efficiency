namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.V_RevealExport")]
    public partial class V_RevealExport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public int? AirlineId { get; set; }

        [StringLength(100)]
        public string Airline { get; set; }

        [StringLength(50)]
        public string ContactEmail { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ExportDate { get; set; }

        [StringLength(50)]
        public string Operator { get; set; }

        public int? Quantity { get; set; }

        public byte? Direction { get; set; }

        [StringLength(4)]
        public string Job { get; set; }
    }
}
