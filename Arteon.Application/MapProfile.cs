using Arteon.Application.DTO;
using Arteon.Application.Models;
using Arteon.Core.Entities;
using Arteon.Core.Models;
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
            CreateMap<RoomFilterParametersDTO, RoomFilterParameters>().ReverseMap();
            CreateMap<ClientStatisticDTO, ClientStatistic>().ReverseMap();
            CreateMap<ClientStatisticFilterDTO, ClientStatisticFilter>().ReverseMap();
            CreateMap<BookingReport, BookingReportDTO>().ReverseMap();
        }
    }
}
