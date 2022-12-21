using System.Reflection;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace OnlineMovieWebApplication.MVC.Model
{
    public class Director
    {
        public string? DirectorID { get; set; }
        public string? DirectorImageUrl { get; set; }
        public string? DirectorName { get; set; }
        public string? DirectorSurname { get; set; }
        public string? DirectorAge { get; set; }
        public string? DirectorMadeMovies { get; set; }
        public string? DirectorNation { get; set; }
    }
}
