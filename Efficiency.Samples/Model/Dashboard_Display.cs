namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("param.Dashboard_Display")]
    public partial class Dashboard_Display
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dashboard_Display()
        {
            Dashboard_Form = new HashSet<Dashboard_Form>();
        }

        public int ID { get; set; }

        public int Dashboard_Display_Collection_ID { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public virtual Dashboard_Display_Collection Dashboard_Display_Collection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dashboard_Form> Dashboard_Form { get; set; }
    }
}
