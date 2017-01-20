namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("controlresult.V_SearchPerson")]
    public partial class V_SearchPerson
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengerId { get; set; }

        public long? PassengerFioRusId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        [StringLength(3)]
        public string CitizenshipIcao { get; set; }

        [StringLength(3)]
        public string Sex { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string Fio { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsDeleted { get; set; }
    }
}
