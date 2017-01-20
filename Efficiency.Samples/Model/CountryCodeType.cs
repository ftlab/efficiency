namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.CountryCodeType")]
    public partial class CountryCodeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CountryCodeType()
        {
            CountryCode = new HashSet<CountryCode>();
        }

        public byte ID { get; set; }

        public byte CodeLen { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CountryCode> CountryCode { get; set; }
    }
}
