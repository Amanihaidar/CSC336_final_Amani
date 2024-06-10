using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Rapping;
using BLL.Rapping.Exceptions;
using DAL.Repositories.Generic;

namespace BLL.Services.Generic
{
    public class GenericService<Entity, Dto> : IGenericService<Dto>
        where Entity : class
        where Dto : class
    {
        public readonly IGenericRepository<Entity> _repository;
        public readonly IMapper _mapper;

        public GenericService(IGenericRepository<Entity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public ApiResponse<Dto> Add(Dto dto)
        {
            var response = new ApiResponse<Dto>();
            var entity = _mapper.Map<Entity>(dto);

            if (entity == null)
            {
                throw new NotFoundException("Not Found");
            }
            var result = _repository.Add(entity);
            response.Data = _mapper.Map<Dto>(result);
            return response;
        }

        public virtual ApiResponse<bool> Delete(Dto dto) //virtual is giving permission to do 
                                                         //override
        {
            var response = new ApiResponse<bool>();
            var entity = _mapper.Map<Entity>(dto);
            response.Data = _repository.Delete(entity);
            return response;
        }


        public ApiResponse<Dto> GetById(int id)
        {
            var response = new ApiResponse<Dto>();
            var result = _repository.GetById(id);
            response.Data = _mapper.Map<Dto>(result);
            return response;
        }

        public ApiResponse<Dto> Update(Dto dto)
        {
            var response = new ApiResponse<Dto>();
            var entity = _mapper.Map<Entity>(dto);
            var result = _repository.Update(entity);
            response.Data = _mapper.Map<Dto>(result);
            return response;
        }

        public ApiResponse<IEnumerable<Dto>> GetAll()
        {
            var response = new ApiResponse<IEnumerable<Dto>>();
            var result = _repository.GetAll();
            response.Data = _mapper.Map<IEnumerable<Dto>>(result);
            return response;
        }
    }

}

