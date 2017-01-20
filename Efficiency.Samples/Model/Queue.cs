namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("staffnotify.Queue")]
    public partial class Queue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Queue()
        {
            Address = new HashSet<Address>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long SenderID { get; set; }

        [Required]
        [StringLength(50)]
        public string NotificationType { get; set; }

        public int? Priority { get; set; }

        public DateTime TTL { get; set; }

        [Required]
        [StringLength(50)]
        public string SenderName { get; set; }

        public bool? RequireProof { get; set; }

        public bool IsSenderPTK { get; set; }

        [Column(TypeName = "xml")]
        public string SecurityLabel { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string Message { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Address { get; set; }
    }
}
