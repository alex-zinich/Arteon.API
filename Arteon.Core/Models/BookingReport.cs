namespace Arteon.Core.Models
{
    public class BookingReport
    {
        public BookingReport(IEnumerable<ClientStatistic> clientStatistics)
        {
            ClientStatistics = clientStatistics;
            TotalBookings = ClientStatistics.Sum(cs => cs.NumberOfBookings);
            TotalIncome = ClientStatistics.Sum(cs => cs.TotalIncome);
            TotalDiscountAmount = ClientStatistics.Sum(cs => cs.DiscountAmount);
            AverageBookingPrice = Math.Round(TotalIncome / TotalBookings, 2);

            foreach (ClientStatistic stat in ClientStatistics)
            {
                stat.Percentage = Math.Round(stat.TotalIncome * 100 / TotalIncome, 1);
            }
        }
        public IEnumerable<ClientStatistic> ClientStatistics { get; init; }
        public int TotalBookings { get; init; }
        public double AverageBookingPrice { get; init; }
        public double TotalPercentage { get; } = 100;
        public double TotalDiscountAmount { get; init; }
        public double TotalIncome { get; init; }
    }
}
