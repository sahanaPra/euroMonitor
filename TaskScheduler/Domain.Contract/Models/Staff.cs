namespace Domain.Contract.Models
{
    public class Staff
    {
        public int Id { get; set; }

        public string StaffName { get; set; }

        public int AvailableHours { get; set; }

        public Task Task { get; set; }
    }
}
