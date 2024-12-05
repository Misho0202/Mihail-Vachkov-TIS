using MovieStoreC.BL.Interfaces;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.BL.Services
{
    internal class MoviesService : IMoviesService
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void Add(Movie movie)
        {
            //_movieRepository.Add(movie);
        }

        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }

        public Movie? GetById(int id)
        {
            if (id <= 0) return null;

            return _movieRepository.GetById(id);
        }
    }
}
