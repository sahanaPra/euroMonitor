using System.ComponentModel.DataAnnotations;

namespace Repository.Entities
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }

        public string StaffName { get; set; }

        public int AvailableHours { get; set; }
    }
}
