using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
    public class TunesDao
    {
         DaydanDbContext db = null;
        public TunesDao()
        {
            db = new DaydanDbContext();
        }
        public GiaiDieu VideoByGiaiDieu(long id)
        {
            return db.GiaiDieu.Find(id);
        }
    }
}
