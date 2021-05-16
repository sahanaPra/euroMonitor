using Domain.Contract.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task = Domain.Contract.Models.Task;

namespace Domain.Contract
{
    public interface ITaskService
    {
        public Task<int> AssignTaskToStaffMember(StaffTaskMapping task);

        public Task<List<Task>> GetAllTasks();
    }
}
