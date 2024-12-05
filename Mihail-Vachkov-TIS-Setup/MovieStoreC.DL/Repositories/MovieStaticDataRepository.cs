using MovieStoreC.DL.Interfaces;
using MovieStoreC.DL.StaticData;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Repositories
{
    internal class MovieStaticDataRepository : IMovieRepository
    {
        public List<Movie> GetAll()
        {
            return StaticDb.Movies;
        }

        public Movie? GetById(int id)
        {
            if (id <= 0) return null;

            return StaticDb.Movies
                .FirstOrDefault(x => x.Id == id);
        }
    }

   
}
