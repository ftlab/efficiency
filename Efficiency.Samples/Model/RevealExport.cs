namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.RevealExport")]
    public partial class RevealExport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public int? AirlineID { get; set; }

        public int? Quantity { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ExportDate { get; set; }

        public byte[] File { get; set; }

        [StringLength(50)]
        public string Operator { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        public byte? Direction { get; set; }

        [StringLength(4)]
        public string Job { get; set; }
    }
}
