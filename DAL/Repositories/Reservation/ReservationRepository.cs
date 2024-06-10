using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories.Generic;
using DAL.Repositories.Pilots;

namespace DAL.Repositories.Reservations
{
    public class ReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(AirplaneSystemContext airplaneSystemContext) : base(airplaneSystemContext)
        {


        }
    
    }
}
