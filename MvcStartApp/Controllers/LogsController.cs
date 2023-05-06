using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models.Db;

namespace MvcStartApp.Controllers
{
    public class LogsController : Controller
    {
        private readonly ILogRepository _repo;

        public LogsController(ILogRepository repo)
        {
            _repo = repo;
        }
        
        /// <summary>
        /// Выводим список запросов
        /// </summary>
        public async Task<IActionResult> Index()
        {
            var reports = await _repo.GetLogs();
            return View(reports);
        }
    }
}
