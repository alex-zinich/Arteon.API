using Arteon.Core.Services.Database;
using Arteon.Infrastructure.Context;

namespace Arteon.WebAPI.Extensions
{
    public static class ServiceComponentDI
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddTransient<IHotelContext, HotelContext>();
        }
    }
}
