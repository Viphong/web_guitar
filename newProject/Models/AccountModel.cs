using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
using System.Data.SqlClient;

namespace Models
{
    public class AccountModel
    {
        private DaydanDbContext context = null;

        public AccountModel()
        {
            context = new DaydanDbContext();
        }
        public bool Login(string userName, string passWord)
        {
            object[] sqlParams = {
                                     new SqlParameter("@Username",userName),
                                     new SqlParameter ("@Password",passWord),
                                 };
            var res = context.Database.SqlQuery<bool>("ThanhVienLogin @Username, @Password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
