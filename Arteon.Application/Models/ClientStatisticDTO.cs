namespace Arteon.Application.Models
{
    public class ClientStatisticDTO
    {
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
        public int TotalBookings { get; set; }
        public double AverageBookingPrice { get; set; }
        public double TotalExpenses { get; set; }
    }
}
