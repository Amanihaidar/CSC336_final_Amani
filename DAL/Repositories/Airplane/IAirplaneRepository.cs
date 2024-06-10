using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories.Generic;

namespace DAL.Repositories.Airplanes
{
    public interface IAirplaneRepository : IGenericRepository<Airplane>
    {
    }
}
