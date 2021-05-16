using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        public string TaskName { get; set; }

        public int Hours { get; set; }
    }
}
