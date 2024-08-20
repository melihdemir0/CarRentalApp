using System;
using System.Collections.Generic;
using CarRentalApp.Data;

namespace CarRentalApp.Business
{
    public class BaseBusiness<TEntity> where TEntity : class
    {
        private BaseRepository<TEntity> _repository;

        public BaseBusiness()
        {
            _repository = new BaseRepository<TEntity>();
        }

        public void Add(TEntity entity)
        {
            try
            {
                _repository.Add(entity);
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while adding the entity.", e);
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                _repository.Update(entity);
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while updating the entity.", e);
            }
        }

        public void Delete(TEntity entity)
        {
            try
            {
                _repository.Delete(entity);
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while deleting the entity.", e);
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while retrieving the entity by ID.", e);
            }
        }

        public List<TEntity> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while retrieving all entities.", e);
            }
        }
    }
}
