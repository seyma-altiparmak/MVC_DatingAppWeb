using System.Reflection;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace OnlineDateApplication.MVC.Model.EF.EF_ActorList
{
    public class Actor
    {
        //statics
        public int ActorID { get; set; } //PK isn't nullable 
        public string? ActorName { get; set; }
        public string? ActorSurname { get; set; }
        public int? ActorAge { get; set; }
        public string? ActorNation { get; set; }

        //dinamik
        public string? ActorImageUrl { get; set; }
        public string? ActorPlayedMovies { get; set; }
    }
}
