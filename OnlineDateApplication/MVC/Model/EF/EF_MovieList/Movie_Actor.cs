using System.Reflection;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using OnlineMovieWebApplication.MVC.Model;


namespace OnlineDateApplication.MVC.Model.EF.EF_MovieList
{
    public class Movie_Actor
    {
        public Movie? MovieID { get; set; }
        public Actor? ActorID { get; set; }
    }
}
