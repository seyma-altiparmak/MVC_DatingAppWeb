using Microsoft.EntityFrameworkCore;

namespace OnlineDateApplication.MVC.Model.EF.EF_MovieList
{
    public class ApplicationDbCntxt : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public ApplicationDbCntxt(DbContextOptions<ApplicationDbCntxt> options) : base(options)
        {

        }
    }
}
