using BLL.DTO;
using BLL.Services.Passengers;
using BLL.Services.Pilots;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_final_Amani.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PilotController : GenericController<PilotDto>
    {
        public readonly IPilotService _pilotService;

        public PilotController(IPilotService service) : base(service)
        {
            _pilotService = service;
        }
    }
}
