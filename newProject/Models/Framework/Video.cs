namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Video")]
    public partial class Video
    {
        [Key]
        public int Mavideo { get; set; }

        [StringLength(50)]
        public string Tenvideo { get; set; }

        public DateTime? Ngaydang { get; set; }

        public int? MaThanhVien { get; set; }

        public int? Luotthich { get; set; }

        public int? Luotxem { get; set; }

        [StringLength(10)]
        public string Trangthai { get; set; }

        public int? Mablog { get; set; }

        public int? MaBG { get; set; }

        public int? MaGD { get; set; }

        [StringLength(225)]
        public string HinhAnh { get; set; }

        [StringLength(225)]
        public string MetaTitle { get; set; }

        public DateTime? NgayChinhSua { get; set; }

        [StringLength(255)]
        public string Link { get; set; }

        public virtual BaiGiang BaiGiang { get; set; }

        public virtual Blog Blog { get; set; }

        public virtual GiaiDieu GiaiDieu { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }
    }
}
