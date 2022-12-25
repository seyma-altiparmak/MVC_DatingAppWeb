using System.Reflection;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using OnlineDateApplication.MVC.Model.EF.EF_UserList;

namespace OnlineDateApplication.MVC.Model.EF.EF_MovieList
{
    public class Comment
    {
        //Movie_User_Comment
        public string? CommentID { get; set; }
        public User? UserID { get; set; }
        public string? CommentContent { get; set; }
    }
}
