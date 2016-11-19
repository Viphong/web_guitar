namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiGiang")]
    public partial class BaiGiang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaiGiang()
        {
            Video = new HashSet<Video>();
        }

        [Key]
        public int MaBaiGiang { get; set; }

        [StringLength(30)]
        public string TenBaiGiang { get; set; }

        public int? MaLoaiBG { get; set; }

        public DateTime? NgayDang { get; set; }

        public int? MaThanhVien { get; set; }

        [StringLength(255)]
        public string NoiDung { get; set; }

        public int? MaCD { get; set; }

        public int? MaGD { get; set; }

        public virtual ChuDe ChuDe { get; set; }

        public virtual GiaiDieu GiaiDieu { get; set; }

        public virtual LoaiBaiGiang LoaiBaiGiang { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Video> Video { get; set; }
    }
}
