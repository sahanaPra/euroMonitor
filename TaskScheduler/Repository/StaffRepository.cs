using AutoMapper;
using Contract.Repository;
using Domain.Contract.Models;
using Repository.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class StaffRepository : IStaffRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public StaffRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException();
            _mapper = mapper;
        }
        public async Task<int> AddStaffMember(Staff staff)
        {
            var staffEntities = MapStaffModelToEntity(staff);
            _context.Add(staffEntities);
            return await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<IList<Staff>> GetAllStaff()
        {
            var staffEntities = await _context.Staffs.ToListAsync();
            return MapStaffEntityToModel(staffEntities);
        }

        private static Entities.Staff MapStaffModelToEntity(Staff staff)
        {
            //return _mapper.Map<Entities.Staff>(staff);
            return new Entities.Staff()
            {
                AvailableHours = staff.AvailableHours,
                StaffName = staff.StaffName
            };
        }

        private static List<Staff> MapStaffEntityToModel(List<Entities.Staff> staff)
        {
            //return _mapper.Map<Entities.Staff>(staff);
            return staff.Select(c => new Staff()
            {
                AvailableHours = c.AvailableHours,
                Id = c.Id,
                StaffName = c.StaffName,
            }).ToList();
        }
    }
}
