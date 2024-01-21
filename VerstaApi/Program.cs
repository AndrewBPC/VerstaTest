using Microsoft.EntityFrameworkCore;
using VerstaApi.Data;
using VerstaApi.Services;

namespace VerstaApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("Docker");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {

                options.UseNpgsql(connectionString);
                options.EnableDetailedErrors();
                options.EnableSensitiveDataLogging();
            });

            builder.Services.AddControllers();
            builder.Services.AddScoped<IOrderService, OrderService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
