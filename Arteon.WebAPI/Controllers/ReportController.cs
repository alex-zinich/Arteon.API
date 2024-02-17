using Arteon.Application.DTO;
using Arteon.Application.Models;
using Arteon.Core.Entities;
using Arteon.Core.Models;
using Arteon.Core.Services;
using Arteon.Core.Services.Database;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Arteon.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IStatisticService _statisticService;

        public ReportController(IMapper mapper, IStatisticService statisticService)
        {
            _mapper = mapper;
            _statisticService = statisticService;
        }

        [HttpGet()]
        public IActionResult GetStatistic([FromQuery] ClientStatisticFilterDTO parameters)
        {
            return Ok(_mapper.Map<IEnumerable<ClientStatistic>, IEnumerable<ClientStatisticDTO>>(
                _statisticService.GetBookingStatistic(_mapper.Map<ClientStatisticFilterDTO, ClientStatisticFilter>(parameters))));
        }
    }
}
