namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("staffnotify.v_ArmGroup")]
    public partial class v_ArmGroup
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Hostname { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }

        [StringLength(100)]
        public string DisplayName { get; set; }

        public bool? IsPTK { get; set; }

        [StringLength(600)]
        public string EmployeeFullName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ArmGroupID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string ArmGroupName { get; set; }
    }
}
