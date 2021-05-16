using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;

namespace Repository.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder is null)
                throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("Staff", "dbo");
                entity.HasKey(x => x.Id);
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("Task", "dbo");
                entity.HasKey(x => x.Id);
            });

            modelBuilder.Entity<StaffTaskMapping>(entity =>
            {
                entity.ToTable("StaffTaskMappings", "dbo");
                entity.HasKey(x => x.Id);
                entity.HasOne(x => x.Task);
                entity.HasOne(x => x.Staff);
            });
        }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<StaffTaskMapping> StaffTaskMappings { get; set; }


    }
}
