﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newProject.Areas.Admin.Models
{
    public class LoginModel
    {
        public string Username { set; get; }
        public string Password { set; get; }
        public bool RememberMe { set; get; }
    }
}