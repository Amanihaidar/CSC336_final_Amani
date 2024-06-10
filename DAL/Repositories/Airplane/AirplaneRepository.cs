using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories.Flights;
using DAL.Repositories.Generic;

namespace DAL.Repositories.Airplanes
{
    public class AirplaneRepository : GenericRepository<Airplane>, IAirplaneRepository
    {
        public AirplaneRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext)
        {


        }
    
    }
}
