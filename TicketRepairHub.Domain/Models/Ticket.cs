namespace TicketRepairHub.Domain.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public bool IsTicketClosed { get; set; }
        public string? UserName { get; set; }
        public DateTime CreatedAtDate { get; set; }
        public DateTime ClosedAtDate { get; set; }
        public TestResult? Result { get; set; } // Foreign key reference
        public TestLimit? Limits { get; set; } // Foreign key reference
        public string? FailedOnTest { get; set; }
        public string? FailedOnPart { get; set; }
        public string? FailedOnPartDescription { get; set; }
        public string? OperatorComment { get; set; }
    }
}