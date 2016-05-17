using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyToDo.Model;

namespace MyToDo.Controllers
{
    public class TodoController : Controller
    {
        // GET: /<controller>/
        
        public IActionResult Index([FromServices] TodoContext context)
        {
            return View(context.Todos.ToList());
        }
    }
}
