namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KSBinfo.LastProhod")]
    public partial class LastProhod
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CardID { get; set; }

        [Required]
        [StringLength(60)]
        public string ObjectID { get; set; }

        public long? MapObjectsID { get; set; }

        public DateTime? Date { get; set; }

        public virtual MapObjects MapObjects { get; set; }
    }
}
