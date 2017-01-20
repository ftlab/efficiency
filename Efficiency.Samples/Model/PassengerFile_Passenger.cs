namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanPerson.PassengerFile_Passenger")]
    public partial class PassengerFile_Passenger
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengerFileID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengerID { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte OperationTypeID { get; set; }

        public virtual Passenger1 Passenger1 { get; set; }

        public virtual PassengerFile PassengerFile { get; set; }

        public virtual PassengerOperationType PassengerOperationType { get; set; }
    }
}
