using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newProject.Areas.Admin.Code
{
    public class SessionHelper
    {
        public static void SetSession(Usersession session)
        {
            HttpContext.Current.Session["loginSession"] = session;
        }
        public static Usersession GetSession()
        {
            var session = HttpContext.Current.Session["loginSession"];
            if (session == null)
                return null;
            else
                return session as Usersession;
        }
    }
}