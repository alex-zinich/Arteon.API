using Arteon.Application.DTO;
using Arteon.Core.Entities;
using Arteon.Core.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Arteon.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IBookingService _bookingService;

        public BookingController(IMapper mapper, IBookingService bookingService)
        {
            _mapper = mapper;
            _bookingService = bookingService;
        }

        [HttpPost("book")]
        public IActionResult BookRoom([FromBody] BookingDTO booking)
        {
            _bookingService.BookRoom(_mapper.Map<BookingDTO, Booking>(booking));

            return Ok();
        }
    }
}
