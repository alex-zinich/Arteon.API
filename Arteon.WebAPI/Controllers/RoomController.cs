using Arteon.Application.DTO;
using Arteon.Application.Models;
using Arteon.Core.Entities;
using Arteon.Core.Models;
using Arteon.Core.Services;
using Arteon.Core.Services.Database;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Arteon.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRoomRepository _roomRepository;
        private readonly IRoomService _roomService;

        public RoomController(IMapper mapper, IRoomRepository roomRepository, IRoomService roomService)
        {
            _mapper = mapper;
            _roomRepository = roomRepository;
            _roomService = roomService;
        }

        [HttpGet("all")]
        public IActionResult GetRooms()
        {
            return Ok(_mapper.Map<IEnumerable<Room>, IEnumerable<RoomDTO>>(_roomRepository.GetRooms()));
        }

        [HttpGet("filter")]
        public IActionResult FilterRooms([FromQuery] RoomFilterParametersDTO parameters)
        {
            return Ok(_mapper.Map<IEnumerable<Room>, IEnumerable<RoomDTO>>(
                _roomService.Filter(_mapper.Map<RoomFilterParametersDTO, RoomFilterParameters>(parameters))));
        }

        //[HttpPost]
        //public IActionResult AddRoom([FromBody] RoomDTO room)
        //{
        //    Room roomEntity = _mapper.Map<RoomDTO, Room>(room);

        //    _context.Rooms.Add(roomEntity);
        //    _context.SaveChanges();
        //    return Ok();
        //}
    }
}
