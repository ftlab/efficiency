namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_EGISOTB_AviaPlanPassenger
    {
        public long Id { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] RowVers { get; set; }

        public Guid arrayId { get; set; }

        [Required]
        [StringLength(12)]
        public string RId { get; set; }

        [StringLength(30)]
        public string name { get; set; }

        [StringLength(30)]
        public string patronymic { get; set; }

        [StringLength(40)]
        public string surname { get; set; }

        [StringLength(1)]
        public string gender_value { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthdate { get; set; }

        [StringLength(30)]
        public string citizenship_value { get; set; }

        [StringLength(20)]
        public string departPlace_value { get; set; }

        public DateTime? departDate { get; set; }

        [StringLength(20)]
        public string ArrivePlace_value { get; set; }

        public DateTime? arriveDate { get; set; }

        [StringLength(1)]
        public string recType { get; set; }

        [StringLength(5)]
        public string operator_value { get; set; }

        [StringLength(1)]
        public string route_value { get; set; }

        public int? reservedSeatsCount { get; set; }

        public long DocumentId { get; set; }

        public short DocumentTypeId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SegmentationKey { get; set; }

        [Required]
        [MaxLength(32)]
        public byte[] DomainKey { get; set; }

        [Required]
        [MaxLength(32)]
        public byte[] Hash { get; set; }

        [StringLength(20)]
        public string route_name { get; set; }
    }
}
