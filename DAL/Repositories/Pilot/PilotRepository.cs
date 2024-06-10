using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories.Airplanes;
using DAL.Repositories.Generic;

namespace DAL.Repositories.Pilots
{
    public class PilotRepository : GenericRepository<Pilot>, IPilotRepository
    {
        public PilotRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext)
        {


        }
    
    }
}
