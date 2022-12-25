using Microsoft.EntityFrameworkCore;

namespace OnlineDateApplication.MVC.Model.EF.EF_MovieList
{
    public class ApplicationDbCntxtDirector : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public ApplicationDbCntxtDirector(DbContextOptions<ApplicationDbCntxtDirector> options) : base(options)
        {

        }
    }
}
