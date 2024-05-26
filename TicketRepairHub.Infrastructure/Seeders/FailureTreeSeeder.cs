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
          
                if (!_dbcontext.FailureTreeParts.Any())
                {
                    _dbcontext.FailureTreeParts.AddRange(
                        new Domain.Models.FailureTreePart() { Part = "Valve", FailureTreeTestId = 0 },
                        new Domain.Models.FailureTreePart() { Part = "Valve", FailureTreeTestId = 1 },
                        new Domain.Models.FailureTreePart() { Part = "Housing", FailureTreeTestId = 0 },
                        new Domain.Models.FailureTreePart() { Part = "Housing", FailureTreeTestId = 2 },
                        new Domain.Models.FailureTreePart() { Part = "Spool", FailureTreeTestId = 2 },
                        new Domain.Models.FailureTreePart() { Part = "Spool", FailureTreeTestId = 3 },
                        new Domain.Models.FailureTreePart() { Part = "Pin", FailureTreeTestId = 0 },
                        new Domain.Models.FailureTreePart() { Part = "Pin", FailureTreeTestId = 4 },
                        new Domain.Models.FailureTreePart() { Part = "O-Ring", FailureTreeTestId = 0 },
                        new Domain.Models.FailureTreePart() { Part = "O-Ring", FailureTreeTestId = 2 },
                        new Domain.Models.FailureTreePart() { Part = "Bolt", FailureTreeTestId = 0 },
                        new Domain.Models.FailureTreePart() { Part = "Bolt", FailureTreeTestId = 3 },
                        new Domain.Models.FailureTreePart() { Part = "GearSet", FailureTreeTestId = 1 },
                        new Domain.Models.FailureTreePart() { Part = "GearSet", FailureTreeTestId = 2 }
                        );
                    await _dbcontext.SaveChangesAsync();
                }

                if (!_dbcontext.FailureTreePartFailures.Any())
                {
                    _dbcontext.FailureTreePartFailures.AddRange(
                        new Domain.Models.FailureTreePartFailure() { PartFailureDecscription = "Cracked valve", FailureTreePartId = 0 },
                        new Domain.Models.FailureTreePartFailure() { PartFailureDecscription = "Small champfer", FailureTreePartId = 1 },
                        new Domain.Models.FailureTreePartFailure() { PartFailureDecscription = "Tight main hole", FailureTreePartId = 2 },
                        new Domain.Models.FailureTreePartFailure() { PartFailureDecscription = "Porous", FailureTreePartId = 3 },
                        new Domain.Models.FailureTreePartFailure() { PartFailureDecscription = "To big diameter", FailureTreePartId = 4 },
                        new Domain.Models.FailureTreePartFailure() { PartFailureDecscription = "Lack of hole", FailureTreePartId = 5 },
                        new Domain.Models.FailureTreePartFailure() { PartFailureDecscription = "Too long", FailureTreePartId = 6 },
                        new Domain.Models.FailureTreePartFailure() { PartFailureDecscription = "Too small", FailureTreePartId = 7 },
                        new Domain.Models.FailureTreePartFailure() { PartFailureDecscription = "Pinch", FailureTreePartId = 8 },
                        new Domain.Models.FailureTreePartFailure() { PartFailureDecscription = "Cracked Bolt", FailureTreePartId = 9 },
                        new Domain.Models.FailureTreePartFailure() { PartFailureDecscription = "Too long", FailureTreePartId = 10 },
                        new Domain.Models.FailureTreePartFailure() { PartFailureDecscription = "Tight GearSet", FailureTreePartId = 11 },
                        new Domain.Models.FailureTreePartFailure() { PartFailureDecscription = "Loose GearSet", FailureTreePartId = 12 },
                        new Domain.Models.FailureTreePartFailure() { PartFailureDecscription = "Cracked valve", FailureTreePartId = 13 }
                        );
                    await _dbcontext.SaveChangesAsync();
                }

                if (!_dbcontext.TestResults.Any())
                {
                    _dbcontext.TestResults.AddRange(
                        new Domain.Models.TestResult() { 
                            Product = "11111111",
                            Serial = "1234A1234",
                            StartTime = new DateTime(2024, 5, 1),
                            StopTime = new DateTime(2024, 5, 1),
                            Operator = "Operator1",
                            IsTotalResultOK = true,
                            TestResult1 = 12.01,
                            IsTestResult1OK = true,
                            TestResult2 = 75.24,
                            IsTestResult2OK = true,
                            TestResult3 = 0.7,
                            IsTestResult3OK = true,
                            TestResult4 = 65.34,
                            IsTestResult4OK = true,
                            TestResult5 = 0.01,
                            IsTestResult5OK = true
                        },
                        new Domain.Models.TestResult()
                        {
                            Product = "11111111",
                            Serial = "1234A1260",
                            StartTime = new DateTime(2024, 5, 20),
                            StopTime = new DateTime(2024, 5, 20),
                            Operator = "Operator1",
                            IsTotalResultOK = false,
                            TestResult1 = 12.01,
                            IsTestResult1OK = true,
                            TestResult2 = 75.24,
                            IsTestResult2OK = true,
                            TestResult3 = 5.01,
                            IsTestResult3OK = false,
                            TestResult4 = 65.34,
                            IsTestResult4OK = true,
                            TestResult5 = 0.01,
                            IsTestResult5OK = true
                        },
                        new Domain.Models.TestResult()
                        {
                            Product = "22222222",
                            Serial = "1234A1278",
                            StartTime = new DateTime(2024, 6, 1),
                            StopTime = new DateTime(2024, 6, 1),
                            Operator = "Operator1",
                            IsTotalResultOK = true,
                            TestResult1 = 12.01,
                            IsTestResult1OK = true,
                            TestResult2 = 75.24,
                            IsTestResult2OK = true,
                            TestResult3 = 0.7,
                            IsTestResult3OK = true,
                            TestResult4 = 65.34,
                            IsTestResult4OK = true,
                            TestResult5 = 0.01,
                            IsTestResult5OK = true
                        },
                        new Domain.Models.TestResult()
                        {
                            Product = "22222222",
                            Serial = "1234A1279",
                            StartTime = new DateTime(2024, 6, 1),
                            StopTime = new DateTime(2024, 6, 1),
                            Operator = "Operator1",
                            IsTotalResultOK = false,
                            TestResult1 = 12.01,
                            IsTestResult1OK = true,
                            TestResult2 = 75.24,
                            IsTestResult2OK = true,
                            TestResult3 = 0.7,
                            IsTestResult3OK = true,
                            TestResult4 = 3.3,
                            IsTestResult4OK = false,
                            TestResult5 = 0.01,
                            IsTestResult5OK = true
                        }
                        );
                    await _dbcontext.SaveChangesAsync();
                }

                if (!_dbcontext.TestLimits.Any())
                {
                    _dbcontext.TestLimits.AddRange(
                        new Domain.Models.TestLimit() { 
                            Product = "11111111",
                            MinTestResult1 = 8.0,
                            MaxTestResult1 = 14.0,
                            MinTestResult2 = 65.0,
                            MaxTestResult2 = 85.0,
                            MinTestResult3 = 0.00,
                            MaxTestResult3 = 1.2,
                            MinTestResult4 = 55.00,
                            MaxTestResult4 = 75.00,
                            MinTestResult5 = 0.00,
                            MaxTestResult5 = 0.1
                        },
                        new Domain.Models.TestLimit()
                        {
                            Product = "22222222",
                            MinTestResult1 = 8.0,
                            MaxTestResult1 = 17.0,
                            MinTestResult2 = 65.0,
                            MaxTestResult2 = 87.0,
                            MinTestResult3 = 0.00,
                            MaxTestResult3 = 1.2,
                            MinTestResult4 = 55.00,
                            MaxTestResult4 = 77.00,
                            MinTestResult5 = 0.00,
                            MaxTestResult5 = 0.17
                        }
                        );
                    await _dbcontext.SaveChangesAsync();
                }
            }
        }
    }
}
