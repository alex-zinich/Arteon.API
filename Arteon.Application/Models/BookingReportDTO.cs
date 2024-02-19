using Arteon.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
