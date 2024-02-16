using System.ComponentModel.DataAnnotations;

namespace Arteon.Application.DTO
{
    public class BookingDTO
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public Guid RoomId { get; set; }
        public bool IsClientVpo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Range(0, double.MaxValue)]
        public double FullPrice { get; set; }
        [Range(0, double.MaxValue)]
        public double PriceWithDiscount { get; set; }
        public string Comment { get; set; }
        public ClientDTO Client { get; set; }
        public ICollection<BookingServiceDTO> BookingServices { get; set; }
    }
}
