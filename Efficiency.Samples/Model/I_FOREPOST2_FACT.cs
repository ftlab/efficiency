namespace Efficiency.Samples.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_FOREPOST2_FACT
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(32)]
        public byte[] Key { get; set; }

        [StringLength(50)]
        public string Source { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateIdentified { get; set; }

        [StringLength(255)]
        public string NameCheckpoint { get; set; }

        [StringLength(255)]
        public string PresenceOldNotify { get; set; }

        [StringLength(201)]
        public string FIODocRus { get; set; }

        [StringLength(201)]
        public string FIODocLat { get; set; }

        [StringLength(8)]
        public string BirthDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDateFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDateTo { get; set; }

        [StringLength(201)]
        public string FIOOURus { get; set; }

        [StringLength(201)]
        public string FIOOULat { get; set; }

        [StringLength(255)]
        public string InitiatorOU { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LimitedTime { get; set; }

        [StringLength(1024)]
        public string BaseDecision { get; set; }

        [StringLength(1024)]
        public string NotificationsOtherOrgans { get; set; }

        [StringLength(1024)]
        public string PlaceNotificationsPS { get; set; }

        [StringLength(255)]
        public string AdministrativeResponsibility { get; set; }

        [StringLength(255)]
        public string PresencePapillaryDesign { get; set; }

        [StringLength(255)]
        public string NumberPapillaryDesign { get; set; }

        [StringLength(255)]
        public string PresencePersonLetter { get; set; }

        [StringLength(255)]
        public string PresenceOperationalMaterials { get; set; }

        [StringLength(255)]
        public string Citizenship { get; set; }

        public byte[] PhotoDocument { get; set; }

        public byte[] PhotoChip { get; set; }

        public byte[] PhotoArchive { get; set; }

        public byte[] PhotoKaskad { get; set; }

        public long DocumentId { get; set; }

        public short DocumentTypeId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SegmentationKey { get; set; }

        [Required]
        [MaxLength(32)]
        public byte[] DomainKey { get; set; }

        [Required]
        [MaxLength(32)]
        public byte[] Hash { get; set; }
    }
}
