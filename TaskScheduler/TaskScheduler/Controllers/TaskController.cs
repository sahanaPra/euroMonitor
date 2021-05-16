using Domain.Contract;
using Domain.Contract.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace TaskScheduler.Controllers
{
    [ApiController]
    [Route("task")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger,
            ITaskService taskService)
        {
            _taskService = taskService;
            _logger = logger;
        }

        /// <summary>
        /// Method to assign task to staff.
        /// </summary>
        /// <param name="task">Mapping entity.</param>
        /// <returns>No Of Records affected</returns>
        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> MapTasksToStaff(StaffTaskMapping task)
        {
            return Ok(await _taskService.AssignTaskToStaffMember(task).ConfigureAwait(false));
        }

        /// <summary>
        /// Method to get all staff members.
        /// </summary>
        /// <returns>List of all Staff members.</returns>
        [HttpGet]
        public async System.Threading.Tasks.Task<ActionResult> GetAllTasks()
        {
            return Ok(await _taskService.GetAllTasks().ConfigureAwait(false));
        }
    }
}
