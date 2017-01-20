namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.V_PossibleAliens")]
    public partial class V_PossibleAliens
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long etId { get; set; }

        [StringLength(256)]
        public string FioRus { get; set; }

        [StringLength(256)]
        public string FioLat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        [StringLength(3)]
        public string CitizenshipIcao { get; set; }

        [StringLength(3)]
        public string Sex { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool IsAlien { get; set; }

        [StringLength(50)]
        public string Note { get; set; }

        [StringLength(50)]
        public string Checked { get; set; }

        public DateTime? CheckResultDate { get; set; }
    }
}
