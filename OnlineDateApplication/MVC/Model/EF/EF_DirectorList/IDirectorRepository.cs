namespace OnlineDateApplication.MVC.Model.EF.EF_MovieList
{
    public interface IDirectorRepository
    {
        IQueryable<Movie> Movies { get; }

    }
}
