﻿using Arteon.Core.Services;
using Arteon.Core.Services.Database;
using Arteon.Core.Services.Statistic;
using Arteon.Infrastructure.Context;
using Arteon.Infrastructure.Repository;

namespace Arteon.WebAPI.Extensions
{
    public static class ServiceComponentDI
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddTransient<IHotelContext, HotelContext>();

            services.AddTransient<IBookingService, BookingService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IRoomService, RoomService>();
            services.AddTransient<IStatisticService, StatisticService>();

            services.AddTransient<IBookingRepository, BookingRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IRoomRepository, RoomRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
        }
    }
}
