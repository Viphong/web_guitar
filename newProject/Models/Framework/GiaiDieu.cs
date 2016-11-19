namespace Models.Framework
{
    using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Tên Giai Điệu")]
        [Required(ErrorMessage="Bạn chưa nhập tên danh mục")]
        public string TenGiaiDieu { get; set; }

        [StringLength(50)]
        [DisplayName("Mô tả")]
        public string MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiGiang> BaiGiang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Video> Video { get; set; }
    }
}
