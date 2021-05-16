using Domain.Contract;
using Domain.Contract.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace TaskScheduler.Controllers
{
    [ApiController]
    [Route("staff")]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly ILogger<StaffController> _logger;

        public StaffController(ILogger<StaffController> logger,
            IStaffService staffService)
        {
            _staffService = staffService;
            _logger = logger;
        }

        /// <summary>
        /// Method to add Staff member.
        /// </summary>
        /// <param name="staff">Staff details.</param>
        /// <returns>No of records inserted.</returns>
        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> AddStaffMember(Staff staff)
        {
            return Ok(await _staffService.AddStaffMember(staff).ConfigureAwait(false));
        }

        /// <summary>
        /// Method to get all staff members.
        /// </summary>
        /// <returns>List of all Staff members.</returns>
        [HttpGet]
        public async System.Threading.Tasks.Task<ActionResult> GetAllStaff()
        {
            return Ok(await _staffService.GetAllStaff().ConfigureAwait(false));
        }
    }
}
