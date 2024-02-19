namespace Arteon.Application.Models
{
    public class ClientStatisticDTO
    {
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
        public int NumberOfBookings { get; set; }
        public double AverageBookingPrice { get; set; }
        public double Percentage { get; set; }
        public double DiscountAmount { get; set; }
        public double TotalIncome { get; set; }
    }
}
