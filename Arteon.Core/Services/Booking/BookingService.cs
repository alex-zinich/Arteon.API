using Arteon.Core.Common;
using Arteon.Core.Entities;
using Arteon.Core.Services.Database;
using Arteon.Core.Services.Mail;

namespace Arteon.Core.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IMailSendService _mailSendService;
        private readonly IClientService _clientService;
        private readonly IRoomRepository _roomRepository;

        public BookingService(IBookingRepository bookingRepository, IMailSendService mailSendService, IClientService clientService, IRoomRepository roomRepository)
        {
            _bookingRepository = bookingRepository;
            _mailSendService = mailSendService;
            _clientService = clientService;
            _roomRepository = roomRepository;
        }

        public async Task BookRoom(Booking booking)
        {
            Client existedClient = _clientService.GetClientByFullNameOrEmail(booking.Client.FullName, booking.Client.Email);

            if (existedClient == null)
            {
                existedClient = _clientService.AddClient(booking.Client.FullName, booking.Client.Email);

                booking.DetachClient().SetClientId(existedClient.Id);
            }
            else
            {
                booking.DetachClient().SetClientId(existedClient.Id);
            }

            _bookingRepository.AddBooking(booking);

            await SendEmailMessage(booking, existedClient);
        }

        private async Task SendEmailMessage(Booking booking, Client client)
        {
            Room room = _roomRepository.GetById(booking.RoomId);

            await _mailSendService.SendEmailAsync(client.Email, "Бронювання підтверженно, готель Premier",
                 $"Дорогий гість! Ваше бронювання номеру у готелі Premier підтвердженно.\n" +
                 $"Дата бронювання {booking.StartDate.ToShortDateString()} - {booking.EndDate.ToShortDateString()}.\n" +
                 $"Інформація про номер: \n" +
                 $"- Кількість осіб: {room.Occupacity}\n" +
                 $"- Номер: {room.RoomNumber}\n" +
                 $"- Тип кімнати: {RoomTypeHelper.GetRoomTypeString(room.RoomTypeId)}\n" +
                 $"\nДо сплати: {booking.PriceWithDiscount} грн.\n" +
                 (booking.IsClientVpo ? $"\nБудь-ласка покажіть довідку ВПО Адміністратору під час поселення\n" : string.Empty) +
                 (!string.IsNullOrEmpty(booking.Comment) ? $"\nМи врахуємо ваші побажання за заданим коментарем: {booking.Comment}" : string.Empty));
        }
    }
}
