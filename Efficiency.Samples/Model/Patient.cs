namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal BorderCrossingID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PatientFlag { get; set; }

        public DateTime? DespatchedDate { get; set; }

        [StringLength(100)]
        public string DespatchedPurpose { get; set; }

        [StringLength(100)]
        public string Hospital { get; set; }

        [StringLength(100)]
        public string HospitalDivision { get; set; }

        [StringLength(100)]
        public string HospitalPhone { get; set; }

        [StringLength(100)]
        public string CardNumber { get; set; }

        public DateTime? TransferDate { get; set; }

        [StringLength(100)]
        public string TransferHospital { get; set; }

        [StringLength(100)]
        public string TransferDivision { get; set; }

        [StringLength(100)]
        public string TransferHospitalPhone { get; set; }
    }
}
