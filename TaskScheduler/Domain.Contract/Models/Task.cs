using System.Collections.Generic;
namespace Domain.Contract.Models
{
    public class Task
    {
        public int Id { get; set; }

        public string TaskName { get; set; }

        public int Hours { get; set; }

        public List<Staff> Staffs { get; set; }
    }
}
