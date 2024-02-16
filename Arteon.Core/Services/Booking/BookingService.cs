using Arteon.Core.Entities;
using Arteon.Core.Services.Database;

namespace Arteon.Core.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IClientService _clientService;

        public BookingService(IBookingRepository bookingRepository, IClientService clientService)
        {
            _bookingRepository = bookingRepository;
            _clientService = clientService;
        }

        public void BookRoom(Booking booking)
        {
            Client existedClient = _clientService.GetClientByFullNameOrEmail(booking.Client.FullName, booking.Client.Email);

            if (existedClient == null)
            {
                Client newClient = _clientService.AddClient(booking.Client.FullName, booking.Client.Email);

                booking.DetachClient().SetClientId(newClient.Id);
            }
            else
            {
                booking.DetachClient().SetClientId(existedClient.Id);
            }

            _bookingRepository.AddBooking(booking);
        }
    }
}
