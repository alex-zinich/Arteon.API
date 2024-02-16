using System.ComponentModel.DataAnnotations;

namespace Arteon.Core.Entities
{
    public class Service : BaseEntity
    {
        public Service(string name, double pricePerDay, Guid? id = null)
        {
            Name = name;
            PricePerDay = pricePerDay;
            Id = id ?? Guid.Empty;
        }
        private Service() { }
        public string Name { get; private set; }
        [Range(0, double.MaxValue)]
        public double PricePerDay { get; private set; }

        // Navigation properties
        public ICollection<BookingService> BookingServices { get; private set; }
    }
}
