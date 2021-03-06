using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task = ApplicationCore.Entities.Task;

namespace TaskManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("")]
        // https://localhost/api/users
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAll();
            if (!users.Any()) return NotFound("No users round");
            return Ok(users);
        }

        [HttpGet("{id:int}/tasks")]
        public async Task<IActionResult> GetUserTasks(int id)
        {
            var tasks = await _userService.GetAllTasksForUser(id);
            if (tasks is null) return NotFound($"No tasks found for this user {id}");
            return Ok(tasks);
        }
        
        [HttpGet("{id:int}/taskshistory")]
        public async Task<IActionResult> GetUserTasksHistory(int id)
        {
            var tasksHistory = await _userService.GetAllTasksHistoryForUser(id);
            if (tasksHistory is null) return NotFound($"No tasks history found for this user {id}");
            return Ok(tasksHistory);
        }

        [HttpPost("add")]
        public async Task<IActionResult> CreateUser(UserRequestModel userRequestModel)
        {
            var result = await _userService.Add(userRequestModel);
            if (!result) return NotFound("Failed to add this user");
            return Ok("User created successfully");
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateUser(UserRequestModel userRequestModel)
        {
            var result = await _userService.Update(userRequestModel);
            if (!result) return NotFound("Failed to update this user");
            return Ok("User updated successfully");
        }

        [HttpPost("delete/:id")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var result = await _userService.Delete(id);
            if (!result) return NotFound("Failed to delete this user");
            return Ok("User deleted successfully");
        }
        
        [HttpPost(":userId/compete/:taskId")]
        public async Task<IActionResult> CompleteTask(int taskId)
        {
            var result = await _userService.CompleteTask(taskId);
            if (!result) return NotFound("Failed to mark this task completed");
            return Ok("Task completed successfully");
        }
    }
}