using System.Reflection;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace OnlineMovieWebApplication.MVC.Model
{
    public class Movie
    {
        public string? MovieID { get; set; }
        public string? MovieCategory { get; set; }
        public Actor? MovieActors { get; set; }
        public Director? DirectorID { get; set; }
        public string? MovieLanguage { get; set; }
        public float? MovieIMDB { get; set; }
        public string? MovieComment { get; set; }
    }
}
