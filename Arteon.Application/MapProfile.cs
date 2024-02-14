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
        }
    }
}
