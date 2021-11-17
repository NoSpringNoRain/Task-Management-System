using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly TaskService _taskService;

        public TasksController(TaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        [Route("")]
        // https://localhost/api/taskshistory
        public async Task<IActionResult> GetAllTasks()
        {
            var tasks = await _taskService.GetAll();
            if (!tasks.Any()) return NotFound("No tasks round");
            return Ok(tasks);
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddTask(TaskRequestModel taskRequestModel)
        {
            var result = await _taskService.Add(taskRequestModel);
            if (!result) return NotFound("Failed to add this task");
            return Ok("Task added successfully");
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateTask(TaskRequestModel taskRequestModel)
        {
            var result = await _taskService.Update(taskRequestModel);
            if (!result) return NotFound("Failed to update this task");
            return Ok("Task updated successfully");
        }

        [HttpPost("delete/:id")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var result = await _taskService.Delete(id);
            if (!result) return NotFound("Failed to delete this task");
            return Ok("Task deleted successfully");
        }
    }
}