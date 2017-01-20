namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ST_TimeShear
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal TimeShearID { get; set; }

        public DateTime DateShear { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Year { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ReportYear { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Halfyear { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ReportHalfyear { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Quarter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ReportQuarter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Month { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ReportMonth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Day { get; set; }
    }
}
