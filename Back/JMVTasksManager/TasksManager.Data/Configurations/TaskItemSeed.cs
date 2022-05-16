using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Data.Entities;

namespace TasksManager.Data.Configurations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskItem>().HasData(
                new TaskItem
                {
                    Id = Guid.NewGuid(),
                    Title = "Task #1",
                    Description = "Description for Task 1",
                    IsCompleted = false
                },
                new TaskItem
                {
                    Id = Guid.NewGuid(),
                    Title = "Task #2",
                    Description = "Description for Task 2",
                    IsCompleted = false
                },
                new TaskItem
                {
                    Id = Guid.NewGuid(),
                    Title = "Task #3",
                    Description = "Description for Task 3",
                    IsCompleted = false
                },
                new TaskItem
                {
                    Id = Guid.NewGuid(),
                    Title = "Task #4",
                    Description = "Description for Task 4",
                    IsCompleted = false
                },
                new TaskItem
                {
                    Id = Guid.NewGuid(),
                    Title = "Task #5",
                    Description = "Description for Task 5",
                    IsCompleted = false
                },
                new TaskItem
                {
                    Id = Guid.NewGuid(),
                    Title = "Task #6",
                    Description = "Description for Task 6",
                    IsCompleted = false
                },
                new TaskItem
                {
                    Id = Guid.NewGuid(),
                    Title = "Task #7",
                    Description = "Description for Task 7",
                    IsCompleted = false
                },
                new TaskItem
                {
                    Id = Guid.NewGuid(),
                    Title = "Task #8",
                    Description = "Description for Task 8",
                    IsCompleted = false
                },
                new TaskItem
                {
                    Id = Guid.NewGuid(),
                    Title = "Task #9",
                    Description = "Description for Task 8",
                    IsCompleted = false
                },
                new TaskItem
                {
                    Id = Guid.NewGuid(),
                    Title = "Task #10",
                    Description = "Description for Task 8",
                    IsCompleted = false
                }
            );
        }
    }
}
