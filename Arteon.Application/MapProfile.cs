using Arteon.Application.DTO;
using Arteon.Core.Entities;
using AutoMapper;

namespace Arteon.Application
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            AllowNullCollections = false;
            ShouldMapProperty = p => true;

            CreateMap<RoomDTO, Room>().ReverseMap();
            CreateMap<BookingDTO, Booking>().ReverseMap();
            CreateMap<ClientDTO, Client>().ReverseMap();
            CreateMap<ServiceDTO, Service>().ReverseMap();
            CreateMap<RoomTypeDTO, RoomType>().ReverseMap();
            CreateMap<BookingServiceDTO, BookingService>().ReverseMap();
        }
    }
}
