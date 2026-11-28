using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Infrastructure.EF;

namespace Infrastructure.Extensions
{
    public static class VelionContextExtensions
    {
        public static void AddVelionContext(this IServiceCollection services, string connection) =>
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));
    }
}
