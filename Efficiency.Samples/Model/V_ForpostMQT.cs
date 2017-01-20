namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.V_ForpostMQT")]
    public partial class V_ForpostMQT
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(256)]
        public string FioRus { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string FioLat { get; set; }

        [StringLength(3)]
        public string CitizenshipIcao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirthFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirthTo { get; set; }

        [StringLength(3)]
        public string Sex { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Direction { get; set; }

        public int? Litera { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long RevealId { get; set; }
    }
}
