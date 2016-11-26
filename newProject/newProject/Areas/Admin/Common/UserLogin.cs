using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newProject.Areas.Admin.Common
{
    [Serializable]
    public class UserLogin
    {
        public long MaThanhVien { set; get; }
        public string Username { set; get; }
    }
}