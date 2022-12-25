namespace OnlineDateApplication.MVC.Model.EF.EF_MovieList
{
    public class EFMovieRepository : IMovieRepository
    {
        private ApplicationDbCntxt _context;

        public EFMovieRepository(ApplicationDbCntxt context)
        {
            _context = context;
        }

        public IQueryable<Movie> Movies => _context.Movies;
    }
}
