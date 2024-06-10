using AutoMapper;
using BLL.DTO;
using BLL.Services.Generic;
using DAL.Models;
using DAL.Repositories.Reservations;

namespace BLL.Services.Reservations
{
    public class ReservationService : GenericService<Reservation, ReservationDto>, IReservationService
    {
        public readonly IReservationRepository _reservationRepository;
        public readonly IMapper _mapper;
        public ReservationService(IReservationRepository reservationRepository, IMapper mapper) : base(reservationRepository, mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;


        }

    }
    
}

