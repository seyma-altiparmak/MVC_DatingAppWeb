﻿using System.Reflection;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace OnlineDateApplication.MVC.Model.EF.EF_UserList
{
    public class User
    {
        public string? UserID { get; set; }
        public string? UserPassword { get; set; }
        public string? UserName { get; set; }
        public string? UserSurname { get; set; }
    }
}
