using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketRepairHub.Domain.Models
{
    public class FailureTreePart
    {
        public int Id { get; set; }
        public string? Part { get; set; }
        public int TestId { get; set; }
    }
}
