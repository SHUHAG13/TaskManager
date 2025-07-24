using TaskManager.Domain.Entities;

namespace TaskManager.Web.Models
{
    public class HomeViewModel
    {
        public int TotalTasks { get; set; }
        public int CompletedTasks { get; set; }
        public int PendingTasks { get; set; }
        public int TodayTasks { get; set; }
        public List<TaskItem> RecentTasks { get; set; } = new();
    }
}
