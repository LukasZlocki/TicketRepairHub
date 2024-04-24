using Microsoft.EntityFrameworkCore;
using TicketRepairHub.Domain.Models;

namespace TicketRepairHub.Infrastructure.Persistance
{
    public class RepairTicketDbContext : DbContext
    {
        public RepairTicketDbContext(DbContextOptions<RepairTicketDbContext> options) : base(options)
        {
            
        }

        public DbSet<FailureTreeTest> FailureTreeTests { get; set; }
        public DbSet<FailureTreePart> FailureTreeParts { get; set; }
        public DbSet<FailureTreePartFailure> FailureTreePartFailures { get; set; }
        public DbSet<TestLimit> TestLimits { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
        public DbSet <Ticket> Tickets { get; set; }
        public DbSet <User> Users { get; set; }
    }
}
