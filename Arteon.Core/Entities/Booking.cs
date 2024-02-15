using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arteon.Core.Entities
{
    public class Booking : BaseEntity
    {
        public Booking(Guid clientId, Guid roomId, bool isClientVpo, DateTime startDate, DateTime endDate, double fullPrice, double priceWithDiscount, string comment = null, Guid? id = null)
        {
            ClientId = clientId;
            RoomId = roomId;
            IsClientVpo = isClientVpo;
            StartDate = startDate;
            EndDate = endDate;
            FullPrice = fullPrice;
            PriceWithDiscount = priceWithDiscount;
            Comment = comment;
            Id = id ?? Guid.Empty;
        }

        private Booking() { }
        public Guid ClientId { get; private set; }
        public Guid RoomId { get; private set; }
        public bool IsClientVpo { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        [Range(0, double.MaxValue)]
        public double FullPrice { get; private set; }
        [Range(0, double.MaxValue)]
        public double PriceWithDiscount { get; private set; }
        public string Comment { get; private set; }

        // Navigation properties
        public Room Room { get; private set; }
        public Client Client { get; private set; }
        public ICollection<BookingService> BookingServices {  get; private set; }
    }
}
