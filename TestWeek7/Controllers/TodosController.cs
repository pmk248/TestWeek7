using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestWeek7.Services;
using TestWeek7.Models;

namespace TestWeek7.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodosService _todosService;

        public TodoController(TodosService todosService)
        {
            _todosService = todosService;
        }

        public async Task<IActionResult> Index()
        {
            var todos = await _todosService.GetAllTodosAsync();
            return View(Index);
        }

        // POST: TodosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
