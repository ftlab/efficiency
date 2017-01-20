namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logptk.Registration")]
    public partial class Registration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Registration()
        {
            Control = new HashSet<Control>();
            FIO = new HashSet<FIO>();
            Passenger = new HashSet<Passenger>();
            Reading = new HashSet<Reading>();
        }

        public long ID { get; set; }

        public Guid AID { get; set; }

        public long Authorization_ID { get; set; }

        public DateTime Created { get; set; }

        public bool AllowCabinPass { get; set; }

        public DateTime? Changed { get; set; }

        public long? UserInfoID { get; set; }

        public int? NumInscribePerson { get; set; }

        public byte? DateBirthFlag { get; set; }

        public int? NumOper { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CitizenShip { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateExpiry { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        public DateTime? StartReg { get; set; }

        public DateTime? StartRegVpis { get; set; }

        public DateTime? EndReg { get; set; }

        public DateTime? Block { get; set; }

        public DateTime? Exit { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? EndReg1 { get; set; }

        public DateTime? NationNull { get; set; }

        public DateTime? DataLost { get; set; }

        public DateTime? NoDocNum { get; set; }

        public DateTime? Skip { get; set; }

        public DateTime? SkipAfterCallSenior { get; set; }

        public DateTime? Delay { get; set; }

        public DateTime? CallSenior { get; set; }

        public DateTime? Change { get; set; }

        public DateTime? Registered { get; set; }

        public DateTime? TempNotSkip { get; set; }

        public TimeSpan? TimeRegistPass { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DocumentCategoryID { get; set; }

        [StringLength(3)]
        public string Sex { get; set; }

        [StringLength(5)]
        public string DocumentNumberCode { get; set; }

        [StringLength(10)]
        public string DocumentNumber { get; set; }

        [StringLength(50)]
        public string Mode { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string Direction { get; set; }

        [StringLength(128)]
        public string Surname { get; set; }

        [StringLength(128)]
        public string GivenName { get; set; }

        [StringLength(128)]
        public string SurnameLatin { get; set; }

        [StringLength(128)]
        public string GivenNameLatin { get; set; }

        [StringLength(255)]
        public string CallSeniorReason { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        [StringLength(1024)]
        public string NumDocError { get; set; }

        public virtual Authorization Authorization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control> Control { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIO> FIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passenger> Passenger { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reading> Reading { get; set; }
    }
}
