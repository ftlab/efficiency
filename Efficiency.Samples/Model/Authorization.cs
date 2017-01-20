namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.Authorization")]
    public partial class Authorization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Authorization()
        {
            SPNDepthControl = new HashSet<SPNDepthControl>();
            ChangeDirection = new HashSet<ChangeDirection>();
            ChangeMode = new HashSet<ChangeMode>();
            Lock = new HashSet<Lock>();
            Message = new HashSet<Message>();
            Registration = new HashSet<Registration>();
        }

        public long ID { get; set; }

        public Guid AID { get; set; }

        public long Starting_ID { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Changed { get; set; }

        public DateTime? RunArmOpk { get; set; }

        [StringLength(100)]
        public string UserLogin { get; set; }

        public DateTime? StatusInitial { get; set; }

        public DateTime? SessionDateTime { get; set; }

        public DateTime? SuccessfulInitDocReader { get; set; }

        public DateTime? CloseSession { get; set; }

        public int? TotalRegisterPass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPNDepthControl> SPNDepthControl { get; set; }

        public virtual Starting Starting { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChangeDirection> ChangeDirection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChangeMode> ChangeMode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lock> Lock { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Message { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registration { get; set; }
    }
}
