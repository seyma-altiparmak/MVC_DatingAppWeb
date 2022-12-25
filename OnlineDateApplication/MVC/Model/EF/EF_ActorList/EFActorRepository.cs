using OnlineDateApplication.MVC.Model.EF.EF_MovieList;

namespace OnlineDateApplication.MVC.Model.EF.EF_ActorList
{
    public class EFActorRepository : IActorRepository
    {
        private ApplicationDbCntxtActor _context;

        public EFActorRepository(ApplicationDbCntxtActor context)
        {
            _context = context;
        }

        public IQueryable<Actor> Actors => _context.Actors;
    }
}
