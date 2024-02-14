using Arteon.Application.DTO;
using Arteon.Core.Entities;
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
        private readonly IHotelContext _context;

        public RoomController(IMapper mapper, IHotelContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetRooms()
        {
            return Ok(_context.Rooms.ToList());
        }

        [HttpPost]
        public IActionResult AddRoom([FromBody] RoomDTO room)
        {
            Room roomEntity = _mapper.Map<RoomDTO, Room>(room);

            _context.Rooms.Add(roomEntity);
            _context.SaveChanges();
            return Ok();
        }
    }
}
