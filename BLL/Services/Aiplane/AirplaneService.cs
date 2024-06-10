using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO;
using BLL.Services.Generic;
using DAL.Models;
using DAL.Repositories.Airplanes;

namespace BLL.Services.Airplanes
{
    public class AirplaneService : GenericService<Airplane, AirplaneDto>, IAirplaneService
    {
        public readonly IAirplaneRepository _airplaneRepository;
        public readonly IMapper _mapper;
        public AirplaneService(IAirplaneRepository airplaneRepository, IMapper mapper) : base(airplaneRepository, mapper)
        {
            _airplaneRepository = airplaneRepository;
            _mapper = mapper;

        }

    }
}
