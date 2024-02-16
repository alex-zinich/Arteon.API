namespace Arteon.Application.DTO
{
    public class BookingServiceDTO
    {
        public Guid Id { get; set; }
        public Guid BookingId { get; set; }
        public Guid ServiceId { get; set; }
        public ServiceDTO Service { get; set; }
    }
}
