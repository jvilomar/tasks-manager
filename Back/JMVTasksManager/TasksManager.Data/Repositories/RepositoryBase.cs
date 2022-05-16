using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TasksManager.Data.Interfaces;

namespace TasksManager.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly TasksManagerContext _dbContext;

        public RepositoryBase(TasksManagerContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<T>> GetAll()
                => await _dbContext.Set<T>().ToListAsync();

        public void Update(T entity)
        { 
            _dbContext.Set<T>().Update(entity);
        }

    }
}
