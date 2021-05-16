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
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public TaskRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException();
            _mapper = mapper;
        }

        public async Task<int> AssignTaskToStaffMember(StaffTaskMapping task)
        {
            var taskEntity = MapModelToEntity(task);
            _context.Add(taskEntity);
           return await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<List<Domain.Contract.Models.Task>> GetAllTasks()
        {
            var taskEntities = await _context.Tasks.ToListAsync();
            return MapEntityToModel(taskEntities);
        }

        private Entities.StaffTaskMapping MapModelToEntity(StaffTaskMapping staffTaskMapping)
        {
            return new Entities.StaffTaskMapping()
            {
                StaffId = staffTaskMapping.StaffId,
                TaskId = staffTaskMapping.TaskId,
            };
        }

        private List<Domain.Contract.Models.Task> MapEntityToModel(List<Entities.Task> tasks)
        {
            return tasks.Select(c => new Domain.Contract.Models.Task()
            {
                Hours = c.Hours,
                Id = c.Id,
                TaskName = c.TaskName,
            }).ToList();
        }
    }
}
