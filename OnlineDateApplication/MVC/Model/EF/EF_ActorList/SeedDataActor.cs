using Microsoft.EntityFrameworkCore;
using OnlineDateApplication.MVC.Model.EF.EF_MovieList;

namespace OnlineDateApplication.MVC.Model.EF.EF_ActorList
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            ApplicationDbCntxtActor con = scope.ServiceProvider.GetRequiredService<ApplicationDbCntxtActor>();

            con.Database.Migrate();

            if (!con.Actors.Any())
            {
                con.Actors.AddRange(
                    new Actor() { ActorName = "Product1", ActorSurname = "1", ActorAge = 100, ActorNation = "cat1" },
                    new Actor() { ActorName = "Product2", ActorSurname = "2", ActorAge = 100, ActorNation = "cat1" },
                    new Actor() { ActorName = "Product3", ActorSurname = "3", ActorAge = 100, ActorNation = "cat1" }

                    );
                con.SaveChanges();
            }
        }
    }
}
