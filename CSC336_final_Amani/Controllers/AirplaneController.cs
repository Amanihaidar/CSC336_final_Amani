using BLL.DTO;
using BLL.Services.Airplanes;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_final_Amani.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AirplaneController : GenericController<AirplaneDto>
    {
        public readonly IAirplaneService _airplaneService;

        public AirplaneController(IAirplaneService service) : base(service)
        {
            _airplaneService = service;
        }
    }
}
