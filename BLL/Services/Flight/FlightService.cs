using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO;
using BLL.Services.Generic;
using DAL.Models;
using DAL.Repositories.Flights;

namespace BLL.Services.Flights
{
    public class FlightService : GenericService<Flight, FlightDto>, IFlightService
    {
        public readonly IFlightRepository _flightRepository;
        public readonly IMapper _mapper;
        public FlightService(IFlightRepository flightRepository, IMapper mapper) : base(flightRepository, mapper)
        {
            _flightRepository = flightRepository;
            _mapper = mapper;

        }
    
    }
}
