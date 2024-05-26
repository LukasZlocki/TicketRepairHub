using TicketRepairHub.Infrastructure.Persistance;

namespace TicketRepairHub.Infrastructure.Seeders
{
    public class FailureTreeSeeder
    {
        private readonly RepairTicketDbContext _dbcontext;

        public FailureTreeSeeder(RepairTicketDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task Seed()
        {
            if(await _dbcontext.Database.CanConnectAsync())
            {
                if (!_dbcontext.FailureTreeTests.Any())
                {
                    _dbcontext.FailureTreeTests.AddRange(
                        new Domain.Models.FailureTreeTest() { TestDescription = "Test1"},
                        new Domain.Models.FailureTreeTest() { TestDescription = "Test2" },
                        new Domain.Models.FailureTreeTest() { TestDescription = "Test3" },
                        new Domain.Models.FailureTreeTest() { TestDescription = "Test4" },
                        new Domain.Models.FailureTreeTest() { TestDescription = "Test5" }
                        );
                    await _dbcontext.SaveChangesAsync();
                }

                /*
                if (!_dbcontext.FailureTreeParts.Any())
                {
                    _dbcontext.FailureTreeTests.AddRange(
                        new Domain.Models.FailureTreePart() { },
                        new Domain.Models.FailureTreeTest() { TestDescription = "Test2" },
                        new Domain.Models.FailureTreeTest() { TestDescription = "Test3" },
                        new Domain.Models.FailureTreeTest() { TestDescription = "Test4" },
                        new Domain.Models.FailureTreeTest() { TestDescription = "Test5" }
                        );
                    await _dbcontext.SaveChangesAsync();
                }
                */
            }
        }
    }
}
