using System.Reflection;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using OnlineDateApplication.MVC.Model.EF.EF_ActorList;
using OnlineDateApplication.MVC.Model.EF.EF_DirectorList;

namespace OnlineDateApplication.MVC.Model.EF.EF_MovieList
{
    public class Movie
    {
        public int? MovieID { get; set; } //PK isn't nullable 
        public string? MovieName { get; set; }
        public string? MovieCategory { get; set; }
        public decimal? MovieIMDB { get; set; }
        public string? MovieLanguage { get; set; }

        //dinamik
        public Actor? MovieActors { get; set; }
        public Director? DirectorID { get; set; }
        public string? MovieComment { get; set; }
    }
}
