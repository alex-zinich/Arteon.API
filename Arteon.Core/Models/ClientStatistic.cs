using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arteon.Core.Models
{
    public class ClientStatistic
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
