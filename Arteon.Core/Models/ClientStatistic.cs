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
        public int TotalBookings { get; set; }
        public double AverageBookingPrice { get; set; }
        public double TotalExpenses { get; set; }
    }
}
