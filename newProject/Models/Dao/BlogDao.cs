using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
    public class BlogDao
    {
        
        DaydanDbContext db = null;
        public BlogDao()
        {
            db = new DaydanDbContext();
        }
        public List<LoaiBlog> ListNameBlog()
        {
            var list = db.Database.SqlQuery<LoaiBlog>("listBlogType").ToList();
            return list;
        }
    }
}
