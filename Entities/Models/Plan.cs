using Microsoft.EntityFrameworkCore;
using schedule_api.Entities.Enums;

namespace schedule_api.Entities.Models
{

    public class Plan
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public PlanType Type { get; set; } = PlanType.basic;
        public DateTime? StartPaidPlan { get; set; }
        public DateTime? EndPaidPlan { get; set; }
        public ICollection<User> Users { get; set; } = [];
    }
}
