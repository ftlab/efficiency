namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.CountryCode")]
    public partial class CountryCode
    {
        public int ID { get; set; }

        public byte CountryCodeTypeID { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(3)]
        public string ICAOCod { get; set; }

        public virtual CountryCodeType CountryCodeType { get; set; }
    }
}
