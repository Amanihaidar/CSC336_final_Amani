using AutoMapper;
using BLL.DTO;
using BLL.Services.Generic;
using DAL.Models;
using DAL.Repositories.Pilots;

namespace BLL.Services.Pilots
{
    public class PilotService : GenericService<Pilot, PilotDto>, IPilotService
    {
        public readonly IPilotRepository _pilotRepository;
        public readonly IMapper _mapper;
        public PilotService(IPilotRepository pilotRepository, IMapper mapper) : base(pilotRepository, mapper)
        {
            _pilotRepository = pilotRepository;
            _mapper = mapper;


        } 
    }
}
