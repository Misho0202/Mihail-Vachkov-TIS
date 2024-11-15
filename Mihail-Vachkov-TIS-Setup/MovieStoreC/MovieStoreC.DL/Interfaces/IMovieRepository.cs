using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Interfaces
{
    public interface IMovieRepository
    {
        void Add(Movie movie);
        List<Movie> GetAll();
    }
}
