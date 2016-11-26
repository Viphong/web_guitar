using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
    public class UserDao
    {
        DaydanDbContext db = null;
        public UserDao()
        {
            db = new DaydanDbContext();
        }
        public long Insert(ThanhVien entity)
        {
            db.ThanhVien.Add(entity);
            db.SaveChanges();
            return entity.MaThanhVien;
        }
        public ThanhVien getUserName(string userName)
        {
            return db.ThanhVien.SingleOrDefault(x=>x.Username == userName);
        }
        public int Login(string userName, string passWord)
        {
            var result = db.ThanhVien.SingleOrDefault(x => x.Username == userName);
                if(result == null)
                    return 0;
                else
                {
                    if(result.Pass == passWord)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                   
        }
      
    }
}
