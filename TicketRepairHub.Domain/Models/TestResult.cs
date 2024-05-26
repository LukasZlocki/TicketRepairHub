namespace TicketRepairHub.Domain.Models
{
    public class TestResult
    {
        public int Id { get; set; }
        public string? Product { get; set; }
        public string? Serial { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public string? Operator { get; set; }
        public bool IsTotalResultOK { get; set; }
        public double TestResult1 { get; set; }
        public bool IsTestResult1OK { get; set; }
        public double TestResult2 { get; set; }
        public bool IsTestResult2OK { get; set; }
        public double TestResult3 { get; set; }
        public bool IsTestResult3OK { get; set; }
        public double TestResult4 { get; set; }
        public bool IsTestResult4OK { get; set; }
        public double TestResult5 { get; set; }
        public bool IsTestResult5OK { get; set; }
    }
}
