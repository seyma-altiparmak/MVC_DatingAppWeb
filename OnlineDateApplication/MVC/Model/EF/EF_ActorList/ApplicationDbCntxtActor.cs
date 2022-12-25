using Microsoft.EntityFrameworkCore;

namespace OnlineDateApplication.MVC.Model.EF.EF_ActorList
{
    public class ApplicationDbCntxtActor : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        public ApplicationDbCntxtActor(DbContextOptions<ApplicationDbCntxtActor> options) : base(options)
        {

        }
    }
}
