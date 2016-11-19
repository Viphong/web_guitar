namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhVien")]
    public partial class ThanhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThanhVien()
        {
            BaiGiang = new HashSet<BaiGiang>();
            Video = new HashSet<Video>();
        }

        [Key]
        public int MaThanhVien { get; set; }

        [StringLength(50)]
        public string TenThanhVien { get; set; }

        public DateTime? Ngaydangky { get; set; }

        public double? Diem { get; set; }

        [StringLength(50)]
        public string Mota { get; set; }

        public int? LoaiThanhVien { get; set; }

        [Required]
        [StringLength(10)]
        public string Username { get; set; }

        [Required]
        [StringLength(12)]
        public string Pass { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Hinhanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiGiang> BaiGiang { get; set; }

        public virtual LoaiThanhVien LoaiThanhVien1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Video> Video { get; set; }
    }
}
