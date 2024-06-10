using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Rapping;
using BLL.Services.Generic;

namespace BLL.Services.Reservations
{
    public interface IReservationService : IGenericService<ReservationDto>
    {
        ApiResponse<ReservationWithPassengerAndFlightDto> AddReservationWithPassengerAndFlight(ReservationWithPassengerAndFlightDto reservationWithPassengerAndFlightDto);
    }
}
