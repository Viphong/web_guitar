using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TunesModel
    {
        private DaydayDbContext context = null;
        public TunesModel()
        {
            context = new DaydayDbContext();
        }
        public List<GiaiDieu> ListAll()
        {
            var list = context.Database.SqlQuery<GiaiDieu>("listGiaiDieu").ToList();
            return list;
        }
    }
}
