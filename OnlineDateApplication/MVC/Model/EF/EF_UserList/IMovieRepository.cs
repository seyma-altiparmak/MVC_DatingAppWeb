namespace OnlineDateApplication.MVC.Model.EF.EF_MovieList
{
    public interface IMovieRepository
    {
        IQueryable<Movie> Movies { get; }

    }
}
