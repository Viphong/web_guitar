namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Blog")]
    public partial class Blog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Blog()
        {
            Video = new HashSet<Video>();
        }

        [Key]
        public int MaBlog { get; set; }

        [StringLength(50)]
        public string TenBlog { get; set; }

        public DateTime? NgayDang { get; set; }

        public int? MaLoaiBlog { get; set; }

        [StringLength(255)]
        public string HinhAnh { get; set; }

        [StringLength(225)]
        public string MetaTitle { get; set; }

        public DateTime? NgayChinhSua { get; set; }

        [StringLength(255)]
        public string Noidung { get; set; }

        [StringLength(10)]
        public string TrangThai { get; set; }

        public int? MaHA { get; set; }

        public virtual HinhAnh HinhAnh1 { get; set; }

        public virtual LoaiBlog LoaiBlog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Video> Video { get; set; }
    }
}
