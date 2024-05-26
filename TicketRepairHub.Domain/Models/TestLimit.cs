namespace TicketRepairHub.Domain.Models
{
    public class TestLimit
    {
        public int Id { get; set; }
        public string? Product { get; set; }
        public double MinTestResult1 { get; set; }
        public double MaxTestResult1 { get; set; }
        public double MinTestResult2 { get; set; }
        public double MaxTestResult2 { get; set; }
        public double MinTestResult3 { get; set; }
        public double MaxTestResult3 { get; set; }
        public double MinTestResult4 { get; set; }
        public double MaxTestResult4 { get; set; }
        public double MinTestResult5 { get; set; }
        public double MaxTestResult5 { get; set; }
    }
}