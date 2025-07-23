using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Web.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
