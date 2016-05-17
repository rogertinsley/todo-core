using Microsoft.AspNetCore.Mvc;

namespace MyToDo.Controllers
{
    public class TodoController : Controller
    {
        // GET: /<controller>/
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
