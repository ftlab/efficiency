namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ADP_Resolution
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal AdministrativeCaseID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ResolutionTypeID { get; set; }

        public DateTime Pronouncement { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LawID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LawClauseID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Part { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PunishmentTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Paragraph { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Point { get; set; }
    }
}
