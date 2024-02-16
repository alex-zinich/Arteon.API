using Arteon.Application.DTO;
using Arteon.Core.Entities;
using Arteon.Core.Services.Database;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Arteon.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IMapper mapper, IServiceRepository serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        [HttpGet("all")]
        public IActionResult GetAllServices()
        {
            return Ok(_mapper.Map<IEnumerable<Service>, IEnumerable<ServiceDTO>>(_serviceRepository.GetAll()));
        }
    }
}
