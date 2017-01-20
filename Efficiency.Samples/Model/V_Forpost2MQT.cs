namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.V_Forpost2MQT")]
    public partial class V_Forpost2MQT
    {
        [Key]
        [Column(Order = 0)]
        public long Id { get; set; }

        [StringLength(201)]
        public string FioRus { get; set; }

        [StringLength(201)]
        public string FioLat { get; set; }

        [StringLength(255)]
        public string CitizenshipIcao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirthFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirthTo { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Direction { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string Litera { get; set; }
    }
}
