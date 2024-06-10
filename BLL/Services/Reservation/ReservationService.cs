using System.Transactions;
using AutoMapper;
using BLL.DTO;
using BLL.Rapping;
using BLL.Rapping.Exceptions;
using BLL.Services.Generic;
using DAL.Models;
using DAL.Repositories.Flights;
using DAL.Repositories.Passengers;
using DAL.Repositories.Reservations;

namespace BLL.Services.Reservations
{
    public class ReservationService : GenericService<Reservation, ReservationDto>, IReservationService
    {
        public readonly IReservationRepository _reservationRepository;
        public readonly IPassengerRepository _passengerRepository;
        public readonly IFlightRepository _flightRepository;
        public readonly IMapper _mapper;
        public ReservationService(IReservationRepository reservationRepository, IFlightRepository flightRepository , IPassengerRepository passengerRepository , IMapper mapper) : base(reservationRepository, mapper)
        {
            _reservationRepository = reservationRepository;
            _passengerRepository = passengerRepository;
            _flightRepository = flightRepository;
            _mapper = mapper;


        }

        public ApiResponse<ReservationWithPassengerAndFlightDto> AddReservationWithPassengerAndFlight(ReservationWithPassengerAndFlightDto reservationWithPassengerAndFlightDto)
        {

            using (TransactionScope scope = new TransactionScope())
            {
                try
                {

                    var response = new ApiResponse<ReservationWithPassengerAndFlightDto>();
                    var reservationentity = _mapper.Map<Reservation>(reservationWithPassengerAndFlightDto);
                    var passengerentities = _mapper.Map<Passenger>(reservationWithPassengerAndFlightDto.PassengerDto);
                    var flightentities = _mapper.Map<Flight>(reservationWithPassengerAndFlightDto.FlightDto);

                    _reservationRepository.Add(reservationentity);

                    reservationentity.PassengerId = reservationentity.PassengerId;

                    reservationentity.FlightId = flightentities.FlightId;

                    _reservationRepository.Add(reservationentity);

                    _flightRepository.Add(flightentities);

                    scope.Complete();


                }
                catch (NotFoundException ex)
                {
                    scope.Dispose();
                    throw new NotFoundException("Not Found");
                }
            }
            return new ApiResponse<ReservationWithPassengerAndFlightDto>(reservationWithPassengerAndFlightDto);

        }
    }
    
}

