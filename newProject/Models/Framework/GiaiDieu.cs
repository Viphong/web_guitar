namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaiDieu")]
    public partial class GiaiDieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiaiDieu()
        {
            BaiGiang = new HashSet<BaiGiang>();
            Video = new HashSet<Video>();
        }

        [Key]
        public int MaGiaiDieu { get; set; }

        [StringLength(20)]
        public string TenGiaiDieu { get; set; }

        [StringLength(50)]
        public string MoTa { get; set; }

        [StringLength(255)]
        public string MetaTile { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiGiang> BaiGiang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Video> Video { get; set; }
    }
}
