using CarRentalApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CarRentalApp.Data
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        public CarRentalContext _context;

        public void Add(TEntity entity)
        {
            _context = new CarRentalContext();
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            _context.Dispose();
        }

        public void Update(TEntity entity)
        {
            _context = new CarRentalContext();
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            _context.Dispose();
        }

        public void Delete(TEntity entity)
        {
            _context = new CarRentalContext();
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
            _context.Dispose();
        }

        public TEntity GetById(int id)
        {
            _context = new CarRentalContext();
            TEntity entity = _context.Set<TEntity>().Find(id);
            _context.Dispose();
            return entity;
        }

        public List<TEntity> GetAll()
        {
            _context = new CarRentalContext();
            List<TEntity> entities = _context.Set<TEntity>().ToList();
            _context.Dispose();
            return entities;
        }
    }
}
