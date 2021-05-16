using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Repository.Entities
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        public string TaskName { get; set; }

        public int Hours { get; set; }
    }
}
