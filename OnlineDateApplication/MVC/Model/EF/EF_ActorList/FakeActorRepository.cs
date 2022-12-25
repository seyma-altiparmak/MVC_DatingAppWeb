using OnlineDateApplication.MVC.Model.EF.EF_MovieList;
using OnlineMovieWebApplication.MVC.Model;

namespace OnlineDateApplication.MVC.Model.EF.EF_ActorList
{
    public class FakeActorRepository : IActorRepository
    {
        public IQueryable<Actor> Actors =>
           new List<Actor>
           {
               //movie id is pk
                new Actor(){ActorID=1, ActorName="M1", ActorSurname="Description1", ActorAge=100, ActorNation="TR"},
                new Actor(){ActorID=2, ActorName="M2", ActorSurname="Description1", ActorAge=100, ActorNation="TR"},
                new Actor(){ActorID=3, ActorName="M3", ActorSurname="Description1", ActorAge=100, ActorNation="TR"},
                new Actor(){ActorID=4, ActorName="M4", ActorSurname="Description1", ActorAge=100, ActorNation="TR"},
                new Actor(){ActorID=5, ActorName="M5", ActorSurname="Description1", ActorAge=100, ActorNation="TR"}

           }.AsQueryable();
    }
}
