
using System.Threading.Tasks;
using System.Collections.Generic;
using ProductManagement.Repositories;

namespace ProductManagement.Services
{
    public abstract class GeneralServiceImpl<TEntity, TRepository>
    where TEntity : class
    where TRepository : IGeneralRepository<TEntity>
    {
        private readonly TRepository repository;
        public GeneralServiceImpl(TRepository repository)
        {
            this.repository = repository;
        }
        public Task<TEntity> Add(TEntity entity)
        {
            return repository.Add(entity);
        }
        public Task<List<TEntity>> GetAll()
        {
            return repository.GetAll();
        }
        public Task<TEntity> Update(TEntity entity)
        {
            return repository.Update(entity);
        }
        public Task<TEntity> Get(int id)
        {
            return repository.Get(id);
        }
        public Task<TEntity> Delete(int id)
        {
            return repository.Delete(id);
        }

    }

}
