namespace TicketRepairHub.Domain.Models
{
    public class FailureTreeTest
    {
        public int Id { get; set; }
        public string? TestDescription { get; set; }
        public ICollection<FailureTreePart>? Parts { get; }
    }
}