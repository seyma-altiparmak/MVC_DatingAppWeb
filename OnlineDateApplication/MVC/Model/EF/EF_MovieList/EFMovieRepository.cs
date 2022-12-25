namespace OnlineDateApplication.MVC.Model.EF.EF_MovieList
{
    public class EFDirectorRepository : IDirectorRepository
    {
        private ApplicationDbCntxtDirector _context;

        public EFDirectorRepository(ApplicationDbCntxtDirector context)
        {
            _context = context;
        }

        public IQueryable<Movie> Movies => _context.Movies;
    }
}
