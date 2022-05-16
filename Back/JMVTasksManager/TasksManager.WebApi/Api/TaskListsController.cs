using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Data.Entities;
using TasksManager.Data.Interfaces;

namespace TasksManager.WebApi.Api
{
    [Route("api/tasks")]
    [ApiController]
    public class TaskListsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TaskListsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetTasksLists([FromQuery] int count = 3)
        {
            var result = await _unitOfWork.TaskLists.GetAll();
            return Ok(result.Take(count));
        }

        [HttpPut]
        public IActionResult CompleteTask([FromBody] TaskItem task)
        {
            _unitOfWork.TaskLists.Update(task);
            _unitOfWork.Complete();
            return NoContent();
        }

    }
}
