using Contract.Repository;
using Domain.Contract;
using Domain.Contract.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<int> AssignTaskToStaffMember(StaffTaskMapping task)
        {
            return await _taskRepository.AssignTaskToStaffMember(task).ConfigureAwait(false);
        }

        public async Task<List<Contract.Models.Task>> GetAllTasks()
        {
            return await _taskRepository.GetAllTasks().ConfigureAwait(false);
        }
    }
}
