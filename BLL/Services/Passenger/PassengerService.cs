using AutoMapper;
using BLL.DTO;
using BLL.Services.Generic;
using DAL.Models;
using DAL.Repositories.Flights;
using DAL.Repositories.Passengers;

namespace BLL.Services.Passengers
{
    public class PassengerService : GenericService<Passenger, PassengerDto>, IPassengerService
    {
        public readonly IPassengerRepository _passengerRepository;
        public readonly IMapper _mapper;
        public PassengerService(IPassengerRepository passengerRepository, IMapper mapper) : base(passengerRepository, mapper)
        {
            _passengerRepository = passengerRepository;
            _mapper = mapper;

        }
    
    }
}
