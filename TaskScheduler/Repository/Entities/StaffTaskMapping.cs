using System.ComponentModel.DataAnnotations;

namespace Repository.Entities
{
    public class StaffTaskMapping
    {
        public virtual Staff Staff { get; set; }
        public virtual Task Task { get; set; }
        public int StaffId { get; set; }
        public int TaskId { get; set; }

        [Key]
        public int Id { get; set; }
    }
}
