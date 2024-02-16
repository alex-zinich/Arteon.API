using System.ComponentModel.DataAnnotations;

namespace Arteon.Application.DTO
{
    public class RoomDTO
    {
        public Guid Id { get; set; }
        public int RoomTypeId { get; set; }
        [Range(101, int.MaxValue)]
        public int RoomNumber { get; set; }
        [Range(1, 5)]
        public int Occupacity { get; set; }
        [Range(0, double.MaxValue)]
        public double PricePerDay { get; set; }

        public ICollection<BookingDTO> Bookings { get; set; }
        public RoomTypeDTO RoomType { get; set; }
    }
}
