namespace TicketRepairHub.Domain.Models
{
    public class FailureTreePartFailure
    {
        public int Id { get; set; }
        public string? PartFailureDecscription { get; set; }
        
        public int FailureTreePartId { get; set; }
        public FailureTreePart? Part { get; set; }
    }
}