using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories.Generic;
using DAL.Repositories.Passengers;

namespace DAL.Repositories.Flights
{
    public class FlightRepository : GenericRepository<Flight>, IFlightRepository
    {
        public FlightRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext)
        {


        }
    
    }
}
