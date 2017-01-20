namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanPerson.PassengerFile")]
    public partial class PassengerFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PassengerFile()
        {
            PassengerFile_Passenger = new HashSet<PassengerFile_Passenger>();
            PassengerJournal = new HashSet<PassengerJournal>();
        }

        public long ID { get; set; }

        public byte? TypeID { get; set; }

        public DateTime DateTimeReceipt { get; set; }

        [Required]
        [StringLength(256)]
        public string FileName { get; set; }

        public virtual PassengerFileType PassengerFileType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PassengerFile_Passenger> PassengerFile_Passenger { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PassengerJournal> PassengerJournal { get; set; }
    }
}
