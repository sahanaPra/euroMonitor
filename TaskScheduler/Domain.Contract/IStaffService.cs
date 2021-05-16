using Domain.Contract.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Contract
{
    public interface IStaffService
    {
        public Task<int> AddStaffMember(Staff staff);

        public Task<IList<Staff>> GetAllStaff();
    }
}
