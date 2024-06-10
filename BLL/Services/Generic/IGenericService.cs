using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Rapping;

namespace BLL.Services.Generic
{
    public interface IGenericService<Dto> where Dto : class
    {
        ApiResponse<IEnumerable<Dto>> GetAll();

        ApiResponse<Dto> GetById(int id);

        ApiResponse<Dto> Add(Dto entity);

        ApiResponse<Dto> Update(Dto entity);

        ApiResponse<bool> Delete(Dto entity);
    

    }
}
