using TasksManager.Data.Entities;
using TasksManager.Data.Interfaces;

namespace TasksManager.Data.Repositories
{
    public class TaskListsRepository : RepositoryBase<TaskItem>, ITaskListsRepository
    {
        public TaskListsRepository(TasksManagerContext context) : 
            base(context)
        {
        }
    }
}
