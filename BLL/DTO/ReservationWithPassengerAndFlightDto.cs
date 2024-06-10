using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.DTO
{
    public class ReservationWithPassengerAndFlightDto
    {
        public int ReservationId { get; set; }

        public int? FlightId { get; set; }

        public int? PassengerId { get; set; }

        public string? SeatNumber { get; set; }

        public DateOnly? ReservationDate { get; set; }



        public FlightDto FlightDto { get; set; }

        public PassengerDto PassengerDto { get; set; }
    }
}
