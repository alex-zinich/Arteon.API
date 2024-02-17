using Arteon.Core.Models;
using Arteon.Core.Services.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arteon.Core.Services.Statistic
{
    public class StatisticService : IStatisticService
    {
        private readonly IHotelContext _hotelContext;

        public StatisticService(IHotelContext hotelContext)
        {
            _hotelContext = hotelContext;
        }

        public IEnumerable<ClientStatistic> GetBookingStatistic(ClientStatisticFilter parameters = null)
        {
            var allBookings = _hotelContext.Bookings.AsNoTracking();

            if (parameters.StartDate != null)
            {
                allBookings = allBookings.Where(b => b.CreatedOn >= parameters.StartDate);
            }

            if (parameters.EndDate != null)
            {
                allBookings = allBookings.Where(b => b.CreatedOn <= parameters.EndDate);
            }

            List<ClientStatistic> output = allBookings.GroupBy(b => b.Client)
                .Select(gr => new ClientStatistic()
                {
                    ClientName = gr.Key.FullName,
                    ClientEmail = gr.Key.Email,
                    TotalBookings = gr.Count(),
                    AverageBookingPrice = gr.Average(b => b.PriceWithDiscount),
                    TotalExpenses = gr.Sum(b => b.PriceWithDiscount)
                })
                .ToList();

            return output;
        }
    }
}
