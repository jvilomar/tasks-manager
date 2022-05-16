using TasksManager.Data.Interfaces;
using TasksManager.Data.Repositories;

namespace TasksManager.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TasksManagerContext _context;
        public ITaskListsRepository TaskLists { get; private set; }
        
        public UnitOfWork(TasksManagerContext context)
        {
            _context = context;
            TaskLists = new TaskListsRepository(context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        { 
            _context.Dispose();
        }

    }
}
