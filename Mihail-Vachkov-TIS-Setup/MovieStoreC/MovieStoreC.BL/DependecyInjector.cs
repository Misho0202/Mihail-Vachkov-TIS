using Microsoft.Extensions.DependencyInjection;
using MovieStoreC.BL.Interfaces;
using MovieStoreC.BL.Services;

namespace MovieStoreC.BL
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            return services.AddSingleton<IMoviesService, MoviesService>();
        }
    }
}
