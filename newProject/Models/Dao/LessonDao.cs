using Models.Framework;
using Models.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
    public class LessonDao
    {
        
        DaydanDbContext db = null;
        public LessonDao()
        {
            db = new DaydanDbContext();
        }
        public List<LoaiBaiGiang> Listlesson()
        {
            return db.LoaiBaiGiang.Where(x => x.TrangThai == true).ToList();
        }
        public List<LessonViewModel> ListAllLesson()
        {
            var model = from a in db.BaiGiang
                        join b in db.Video on a.MaBaiGiang equals b.MaBG
                        join c in db.ChuDe on a.MaCD equals c.MaChuDe
                        join d in db.GiaiDieu on a.MaGD equals d.MaGiaiDieu
                        join e in db.ThanhVien on a.MaThanhVien equals e.MaThanhVien
                        join f in db.HinhAnh on a.MaHA equals f.MaHinhAnh
                        select new LessonViewModel()
                        {
                            MaBaiGiang = a.MaBaiGiang,
                            TenBaiGiang  = a.TenBaiGiang,
                            NgayDang = a.NgayDang,
                            NoiDung = a.NoiDung,
                            MetaTitle = a.MetaTitle,
                            LinkVideo = b.Link,
                            Luotthich = b.Luotthich,
                            Luotxem = b.Luotxem,
                            TenChuDe = c.TenChuDe,
                            TenGiaiDieu = d.TenGiaiDieu,
                            TenThanhVien = e.TenThanhVien,
                            TenHinhAnh = f.TenHinhAnh,
                            LinkHinhAnh = f.LinkHinhAnh,
                            TrangThai = a.TrangThai
                            
                        };
            model.Where(x => x.TrangThai == true);
            return model.ToList();

        }
    }
}
