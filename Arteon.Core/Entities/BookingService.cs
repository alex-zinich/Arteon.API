using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arteon.Core.Entities
{
    public class BookingService : BaseEntity
    {
        public BookingService(Guid bookingId, Guid serviceId, Guid? id = null)
        {
            BookingId = bookingId;
            ServiceId = serviceId;
            Id = id ?? Guid.Empty;
        }

        public Guid BookingId { get; private set; }
        public Guid ServiceId { get; private set; }

        // Navigation properties
        public Booking Booking { get; private set; }
        public Service Service { get; private set; }
    }
}
