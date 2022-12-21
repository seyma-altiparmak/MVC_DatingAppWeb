using System.Reflection;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace OnlineMovieWebApplication.MVC.Model
{
    public class Actor
    {
        public string? ActorID { get; set; }
        public string? ActorImageUrl { get; set; }
        public string? ActorName { get; set; }
        public string? ActorSurname { get; set; }
        public string? ActorAge { get; set;}
        public string? ActorPlayedMovies { get; set;}
        public string? ActorNation { get; set;}
    }
}
