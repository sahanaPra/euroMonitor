using Domain.Contract.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task = Domain.Contract.Models.Task;

namespace Contract.Repository
{
    public interface ITaskRepository
    {
        public Task<int> AssignTaskToStaffMember(StaffTaskMapping task);

        public Task<List<Task>> GetAllTasks();
    }
}
