namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.v_Registration")]
    public partial class v_Registration
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long? Passenger_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BorderCrossing_ID { get; set; }

        [StringLength(50)]
        public string Arm { get; set; }

        [StringLength(100)]
        public string OperatorPC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Direction { get; set; }

        [StringLength(257)]
        public string FIO_RUS { get; set; }

        [StringLength(257)]
        public string FIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirth { get; set; }

        public byte? DateBirthFlag { get; set; }

        [StringLength(3)]
        public string Sex { get; set; }

        [StringLength(15)]
        public string DocumentNumber { get; set; }

        [StringLength(30)]
        public string Citizenship { get; set; }

        [StringLength(30)]
        public string DocumentCategory { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateExpiry { get; set; }

        public long? ArmID { get; set; }

        public DateTime? StartReg { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CrossingLabelID { get; set; }
    }
}
