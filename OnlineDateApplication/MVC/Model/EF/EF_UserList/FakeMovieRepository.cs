using OnlineMovieWebApplication.MVC.Model;

namespace OnlineDateApplication.MVC.Model.EF.EF_MovieList
{
    public class FakeMovieRepository : IMovieRepository
    {
        public IQueryable<Movie> Movies =>
           new List<Movie>
           {
               //movie id is pk
                new Movie(){MovieID=1, MovieName="M1", MovieCategory="Description1", MovieIMDB=100, MovieLanguage="TR"},
                new Movie(){MovieID=2, MovieName="M2", MovieCategory="Description1", MovieIMDB=100, MovieLanguage="TR"},
                new Movie(){MovieID=3, MovieName="M3", MovieCategory="Description1", MovieIMDB=100, MovieLanguage="TR"},
                new Movie(){MovieID=4, MovieName="M4", MovieCategory="Description1", MovieIMDB=100, MovieLanguage="TR"},
                new Movie(){MovieID=5, MovieName="M5", MovieCategory="Description1", MovieIMDB=100, MovieLanguage="TR"}

           }.AsQueryable();
    }
}
