using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task = ApplicationCore.Entities.Task;

namespace TaskManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
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
    }
}