namespace Domain.Contract.Models
{
    public class StaffTaskMapping
    {
        public virtual Staff Staff { get; set; }

        public virtual Task Task { get; set; }

        public int StaffId { get; set; }

        public int TaskId { get; set; }

    }
}
