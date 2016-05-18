using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyToDo.Model;

namespace MyToDo.Controllers
{
    public class TodoController : Controller
    {
        // GET: /todo/
        
        public IActionResult Index([FromServices] TodoContext context)
        {
            return View(context.Todos.ToList());
        }
        
        // GET: /todo/create
        
        public IActionResult Create()
        {
            return View(new Todo());
        }
        
        // POST: /todo/create
        
        [HttpPost]
        public IActionResult Create([FromServices] TodoContext context, Todo todo)
        {
            context.Todos.Add(todo);
            context.SaveChanges();
            
            return RedirectToAction("Index");
        }
        
        // GET: /todo/delete
                
        public IActionResult Delete([FromServices] TodoContext context, int id)
        {
            var entity = context.Todos.Single(t => t.TodoId == id);
            context.Todos.Remove(entity);
            context.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}
