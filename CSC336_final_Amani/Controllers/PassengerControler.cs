using BLL.DTO;
using BLL.Services.Flights;
using BLL.Services.Passengers;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_final_Amani.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PassengerControler : GenericController<PassengerDto>
    {
        public readonly IPassengerService _passengerService;

        public PassengerControler(IPassengerService service) : base(service)
        {
            _passengerService = service;
        }
    }
}
