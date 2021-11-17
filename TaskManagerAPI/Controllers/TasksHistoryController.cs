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
    public class TasksHistoryController : ControllerBase
    {
        private readonly TaskHistoryService _taskHistoryService;

        public TasksHistoryController(TaskHistoryService taskHistoryService)
        {
            _taskHistoryService = taskHistoryService;
        }

        [HttpGet]
        [Route("")]
        // https://localhost/api/taskshistory
        public async Task<IActionResult> GetAllTasksHistory()
        {
            var tasksHistory = await _taskHistoryService.GetAll();
            if (!tasksHistory.Any()) return NotFound("No tasks history round");
            return Ok(tasksHistory);
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddTaskHistory(TaskHistoryRequestModel taskHistoryRequestModel)
        {
            var result = await _taskHistoryService.Add(taskHistoryRequestModel);
            if (!result) return NotFound("Failed to add this task history");
            return Ok("Task history added successfully");
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateTaskHistory(TaskHistoryRequestModel taskHistoryRequestModel)
        {
            var result = await _taskHistoryService.Update(taskHistoryRequestModel);
            if (!result) return NotFound("Failed to update this task history");
            return Ok("Task history updated successfully");
        }

        [HttpPost("delete/:id")]
        public async Task<IActionResult> DeleteTaskHistory(int id)
        {
            var result = await _taskHistoryService.Delete(id);
            if (!result) return NotFound("Failed to delete this task history");
            return Ok("Task history deleted successfully");
        }
    }
}