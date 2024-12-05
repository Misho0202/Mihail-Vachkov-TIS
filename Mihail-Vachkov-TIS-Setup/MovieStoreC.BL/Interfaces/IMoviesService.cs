using MovieStoreC.Models.DTO;

namespace MovieStoreC.BL.Interfaces
{
    public interface IMoviesService
    {
        List<Movie> GetAll();

        Movie? GetById(int id);
        void Add(Movie movie);
    }
}
