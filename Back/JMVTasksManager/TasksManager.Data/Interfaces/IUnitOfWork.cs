using System;

namespace TasksManager.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ITaskListsRepository TaskLists { get; }
        int Complete();
    }
}
