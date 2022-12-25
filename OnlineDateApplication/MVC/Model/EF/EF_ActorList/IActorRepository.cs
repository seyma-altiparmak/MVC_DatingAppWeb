using OnlineDateApplication.MVC.Model.EF.EF_MovieList;

namespace OnlineDateApplication.MVC.Model.EF.EF_ActorList
{
    public interface IActorRepository
    {
        IQueryable<Actor> Actors { get; }

    }
}
