namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HinhAnh")]
    public partial class HinhAnh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HinhAnh()
        {
            BaiGiang = new HashSet<BaiGiang>();
            Blog = new HashSet<Blog>();
        }

        [Key]
        public int MaHinhAnh { get; set; }

        [StringLength(50)]
        public string TenHinhAnh { get; set; }

        public int? MaLoaiHinhAnh { get; set; }

        [StringLength(255)]
        public string LinkHinhAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiGiang> BaiGiang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Blog> Blog { get; set; }

        public virtual LoaiHinhAnh LoaiHinhAnh { get; set; }
    }
}
