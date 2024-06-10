using BLL.DTO;
using BLL.Rapping;
using BLL.Services.Pilots;
using BLL.Services.Reservations;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_final_Amani.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ReservationController : GenericController<ReservationDto>
    {
        public readonly IReservationService _reservationService;

        public ReservationController(IReservationService service) : base(service)
        {
            _reservationService = service;
        }

        [HttpPost("AddReservationWithPassengerAndFlight")]
        public ApiResponse<ReservationWithPassengerAndFlightDto> AddReservationWithPassengerAndFlight(ReservationWithPassengerAndFlightDto reservationWithPassengerAndFlightDto)
        {
            return  _reservationService.AddReservationWithPassengerAndFlight(reservationWithPassengerAndFlightDto);
           
        }
    }
}
