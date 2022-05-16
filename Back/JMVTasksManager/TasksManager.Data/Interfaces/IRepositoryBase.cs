using System.Collections.Generic;
using System.Threading.Tasks;

namespace TasksManager.Data.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        void Update(T entity);
    }
}
