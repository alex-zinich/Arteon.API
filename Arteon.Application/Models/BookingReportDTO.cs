namespace Arteon.Application.Models
{
    public class BookingReportDTO
    {
        public IEnumerable<ClientStatisticDTO> ClientStatistics { get; set; }
        public int TotalBookings { get; set; }
        public double AverageBookingPrice { get; set; }
        public double TotalPercentage { get; set; }
        public double TotalDiscountAmount { get; set; }
        public double TotalIncome { get; set; }
    }
}
