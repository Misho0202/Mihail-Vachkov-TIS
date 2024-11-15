using MovieStoreC.BL;
using MovieStoreC.DL;

namespace MovieStoreC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.RegisterRepositories();
            builder.Services.RegisterServices();

            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                // Configure the HTTP request pipeline.

                app.UseAuthorization();


                app.MapControllers();

                app.Run();
            }
        }
    }
}