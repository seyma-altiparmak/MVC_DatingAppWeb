using Microsoft.EntityFrameworkCore;

namespace OnlineDateApplication.MVC.Model.EF.EF_MovieList
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            ApplicationDbCntxtDirector con = scope.ServiceProvider.GetRequiredService<ApplicationDbCntxtDirector>();

            con.Database.Migrate();

            if (!con.Movies.Any())
            {
                con.Movies.AddRange(
                    new Movie() { MovieName = "Product1", MovieCategory = "1", MovieIMDB = 100, MovieLanguage = "cat1" },
                    new Movie() { MovieName = "Product2", MovieCategory = "2", MovieIMDB = 100, MovieLanguage = "cat1" },
                    new Movie() { MovieName = "Product3", MovieCategory = "3", MovieIMDB = 100, MovieLanguage = "cat1" }

                    );
                con.SaveChanges();
            }
        }
    }
}
