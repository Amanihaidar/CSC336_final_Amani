using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly DbSet<T> _dbSet;
        public readonly AirplaneSystemContext _airplaneSystemContext;
        public GenericRepository(AirplaneSystemContext airplaneSystemContext)
        {
            _airplaneSystemContext = airplaneSystemContext;
            _dbSet = airplaneSystemContext.Set<T>();
        }
        public T Add(T entity)
        {
            var result = _dbSet.Add(entity);
            _airplaneSystemContext.SaveChanges(); //save i always do for the original context
            return entity; // i can write result.Entity
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }


        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public T Update(T entity)
        {
            _dbSet.Update(entity);
            try
            {
                _airplaneSystemContext.SaveChanges();
                ;
            }
            catch (Exception ex) { }
            return entity;
        }

        public bool Delete(T entity)
        {
            _dbSet.Remove(entity);
            try
            {
                _airplaneSystemContext.SaveChanges();
                return false;
            }
            catch
            {
                return false;
            }
        }

    }
}
