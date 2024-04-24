namespace TicketRepairHub.Domain.Models
{
    public class FailureTreePartFailure
    {
        public int Id { get; set; }
        public string? PartFailureDecscription { get; set; }
        public int PartId { get; set; }
    }

}
