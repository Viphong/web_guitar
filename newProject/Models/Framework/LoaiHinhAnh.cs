namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiHinhAnh")]
    public partial class LoaiHinhAnh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiHinhAnh()
        {
            HinhAnh = new HashSet<HinhAnh>();
        }

        [Key]
        public int MaLoaiHinhAnh { get; set; }

        [StringLength(255)]
        public string TenLoaiHinhAnh { get; set; }

        [StringLength(50)]
        public string Mota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HinhAnh> HinhAnh { get; set; }
    }
}
