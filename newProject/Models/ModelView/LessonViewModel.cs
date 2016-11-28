using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelView
{
    public class LessonViewModel
    {
        public int MaBaiGiang { get; set; }

        public string TenBaiGiang { get; set; }

        public DateTime? NgayDang { get; set; }

        public string TenThanhVien { get; set; }

        public string NoiDung { get; set; }

        public string MetaTitle { get; set; }

        public string LinkVideo { get; set; }

        public int? Luotthich { get; set; }

        public int? Luotxem { get; set; }

        public string TenChuDe { get; set; }

        public string TenGiaiDieu { get; set; }

        public string TenHinhAnh { get; set; }

        public string LinkHinhAnh { get; set; }

        public bool? TrangThai { get; set; }

    }
}
