using Arteon.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Arteon.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("isExists")]
        public IActionResult CheckIsUserExists(string fullName, string email)
        {
            return Ok(_clientService.IsUserExist(fullName, email));
        }
    }
}
