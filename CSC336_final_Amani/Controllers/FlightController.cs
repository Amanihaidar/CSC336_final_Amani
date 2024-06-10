using BLL.DTO;
using BLL.Services.Flights;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_final_Amani.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class FlightController : GenericController<FlightDto>
    {
        public readonly IFlightService _flightService;

        public FlightController(IFlightService service) : base(service)
        {
            _flightService = service;
        }
    }
}
