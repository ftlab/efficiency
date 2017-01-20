namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dic.v_ARM")]
    public partial class v_ARM
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ParentId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Hostname { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }

        [StringLength(100)]
        public string DisplayName { get; set; }

        public bool? IsPTK { get; set; }

        [StringLength(600)]
        public string EmployeeFullName { get; set; }
    }
}
