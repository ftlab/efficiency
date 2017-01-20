namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanPerson.v_Passenger_FIO_RUS")]
    public partial class v_Passenger_FIO_RUS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirth { get; set; }

        [StringLength(3)]
        public string Sex { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(256)]
        public string FIO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string LangCode { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(256)]
        public string FIO_RUS { get; set; }
    }
}
