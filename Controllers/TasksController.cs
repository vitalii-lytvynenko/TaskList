using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskList.Context;
using TaskList.Models;

namespace TaskList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ApiContext _context;

        public TasksController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var result = _context.Tasks.ToList();

            if (result == null) {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public ActionResult Create(Models.Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return Ok(task);
        }

        [HttpPatch("{id}")]
        public ActionResult Update(int id, [FromBody] Models.Task taskUpdate)
        {
            var task = _context.Tasks.Find(id);

            if (task == null)
            {
                return NotFound();
            }

            if (taskUpdate.Title != null)
            {
                task.Title = taskUpdate.Title;
            }

            if (taskUpdate.Completed.HasValue)
            {
                task.Completed = taskUpdate.Completed.Value;
            }

            _context.SaveChanges();

            return Ok(task);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var result = _context.Tasks.Find(id);

            if (result == null)
            {
                return NotFound();
            }

            _context.Tasks.Remove(result);
            _context.SaveChanges();

            return Ok(result.Id);
        }
    }
}
