using Domain.Contract.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contract.Repository
{
    public interface IStaffRepository
    {
        public Task<int> AddStaffMember(Staff staff);

        public Task<IList<Staff>> GetAllStaff();
    }
}
