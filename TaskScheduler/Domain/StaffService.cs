using Contract.Repository;
using Domain.Contract;
using Domain.Contract.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain
{
    public class StaffService : IStaffService
    {
        private readonly IStaffRepository _staffRepository;

        public StaffService(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }
        public async Task<int> AddStaffMember(Staff staff)
        {
            return await _staffRepository.AddStaffMember(staff).ConfigureAwait(false);
        }

        public async Task<IList<Staff>> GetAllStaff()
        {
            return await _staffRepository.GetAllStaff().ConfigureAwait(false);
        }
    }
}
