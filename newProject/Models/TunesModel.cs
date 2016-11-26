using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class TunesModel
    {
        private DaydanDbContext context = null;
        public TunesModel()
        {
            context = new DaydanDbContext();
        }
        public List<GiaiDieu> ListAll()
        {
            var list = context.Database.SqlQuery<GiaiDieu>("listGiaiDieu").ToList();
            return list;
        }
        public List<GiaiDieu> ListTunesName()
        {
            return context.GiaiDieu.ToList();
        }
        public int Create(string name, string describle)
        {
            object[] paramaters = {
                                      new SqlParameter ("@name",name),
                                      new SqlParameter("@describle", describle),
                                  };
            int res = context.Database.ExecuteSqlCommand("ThemGiaiDieu @name,@describle", paramaters);
            return res;
        }
    }
}
