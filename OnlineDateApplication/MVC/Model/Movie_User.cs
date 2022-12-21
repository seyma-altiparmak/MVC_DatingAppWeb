using System.Reflection;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace OnlineMovieWebApplication.MVC.Model
{
    public class Comment
    {
        //Movie_User_Comment
        public string? CommentID { get; set; }
        public User? UserID { get; set; }
        public string? CommentContent { get; set; }
    }
}
