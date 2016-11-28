using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;

namespace Models.Dao
{
    public class VideoDao
    {
        DaydanDbContext db = null;
        public VideoDao()
        {
            db = new DaydanDbContext();
        }
        public List<Video> ListNewVideo(int top)
        {
            return db.Video.OrderByDescending(x=>x.Ngaydang).Take(top).ToList();
         
        }
        public List<Video> ListByTunes(long tuneId)
        {
            return db.Video.Where(x => x.MaGD == tuneId).ToList();
        }
        public Video VideoDetail(long id)
        {
            return db.Video.Find(id);
        }
    }
}
