namespace TicketRepairHub.Domain.Models
{
    public class FailureTree
    {
        public int Id { get; set; }
        public string? TestName { get; set; }
        public string? FailedPart { get; set; }
        public string? FailedPartDescription { get; set; }
    }
}
