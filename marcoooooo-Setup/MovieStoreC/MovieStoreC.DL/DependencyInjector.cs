using Microsoft.Extensions.DependencyInjection;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.DL.Repositories;

namespace MovieStoreC.DL
{
  
    public static class DependencyInjection
    {
        public static IServiceCollection  RegisterRepositories(this IServiceCollection services)
        {
          return services.AddSingleton<IMovieRepository, MovieStaticDataRepository>();
        }
    }
}

