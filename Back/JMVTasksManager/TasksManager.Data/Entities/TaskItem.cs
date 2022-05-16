using System;

namespace TasksManager.Data.Entities
{
    public class TaskItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Description { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }

    }
}
