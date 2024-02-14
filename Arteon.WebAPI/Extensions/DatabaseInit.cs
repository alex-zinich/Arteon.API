using Arteon.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Arteon.WebAPI.Extensions
{
    public static class DatabaseInit
    {
        public static void InitDatabase(HotelContext context)
        {
            RelationalDatabaseCreator dbCreator = context.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
            bool isFirstLaunch = !dbCreator.Exists();
            if (isFirstLaunch)
            {
                dbCreator.Create();
                context.Database.Migrate();
            }
            else
            {
                context.Database.Migrate();
            }
        }
    }
}
