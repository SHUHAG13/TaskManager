using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.Interfaces;
using TaskManager.Domain.Entities;
using TaskManager.Web.Models;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace TaskManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskService _taskService;

        public HomeController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public async Task<IActionResult> Index()
        {
            var allTasks = await _taskService.GetAllAsync();
            var today = DateTime.Today;

            var model = new HomeViewModel
            {
                TotalTasks = allTasks.Count(),
                CompletedTasks = allTasks.Count(t => t.IsCompleted),
                PendingTasks = allTasks.Count(t => !t.IsCompleted),
                TodayTasks = allTasks.Count(t => t.DueDate.Date == today),
                RecentTasks = allTasks
                                .OrderByDescending(t => t.DueDate)
                                .Take(3)
                                .ToList()
            };

            return View(model);
        }
    }
}
