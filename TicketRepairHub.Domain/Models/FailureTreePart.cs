namespace TicketRepairHub.Domain.Models
{
    public class FailureTreePart
    {
        public int Id { get; set; }
        public string? Part { get; set; }

        public int FailureTreeTestId { get; set; }
        public FailureTreeTest? Test { get; set; }

        public ICollection<FailureTreePartFailure>? PartFailure{ get; }
    }
}