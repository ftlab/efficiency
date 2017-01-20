namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.v_Control")]
    public partial class v_Control
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID2 { get; set; }

        public long? Passenger_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Direction { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirth { get; set; }

        public byte? DateBirthFlag { get; set; }

        [StringLength(3)]
        public string Sex { get; set; }

        [StringLength(30)]
        public string Citizenship { get; set; }

        [StringLength(10)]
        public string FligthNumber { get; set; }

        [StringLength(257)]
        public string FIO_RUS { get; set; }

        [StringLength(257)]
        public string FIO { get; set; }

        [StringLength(16)]
        public string DocumNumber { get; set; }

        [StringLength(30)]
        public string DocumentCategory { get; set; }

        [StringLength(128)]
        public string TypeDocument { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CrossingLabelID { get; set; }
    }
}
