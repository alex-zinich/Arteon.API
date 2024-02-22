using Arteon.Core.Models;
using Arteon.Core.Services.Database;
using Microsoft.EntityFrameworkCore;

namespace Arteon.Core.Services.Statistic
{
    public class StatisticService : IStatisticService
    {
        private readonly IHotelContext _hotelContext;

        public StatisticService(IHotelContext hotelContext)
        {
            _hotelContext = hotelContext;
        }

        public BookingReport GenerateReport(ClientStatisticFilter parameters = null)
        {
            var allBookings = _hotelContext.Bookings.AsNoTracking();

            if (parameters.StartDate != null)
            {
                allBookings = allBookings.Where(b => b.CreatedOn.Date >= parameters.StartDate);
            }

            if (parameters.EndDate != null)
            {
                allBookings = allBookings.Where(b => b.CreatedOn.Date <= parameters.EndDate);
            }

            List<ClientStatistic> clientStatistics = allBookings.GroupBy(b => b.Client)
                .Select(gr => new ClientStatistic()
                {
                    ClientName = gr.Key.FullName,
                    ClientEmail = gr.Key.Email,
                    NumberOfBookings = gr.Count(),
                    AverageBookingPrice = Math.Round(gr.Average(b => b.PriceWithDiscount), 2),
                    TotalIncome = gr.Sum(b => b.PriceWithDiscount),
                    DiscountAmount = gr.Sum(b => b.FullPrice - b.PriceWithDiscount)
                })
                .ToList();

            return new(clientStatistics);
        }
    }
}
