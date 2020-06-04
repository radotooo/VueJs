
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoAppServer.Features.Task;
using TodoAppServer.Features.Task.Models;

namespace TodoAppServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService taskService;


        public TaskController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        [HttpGet(Name = "Get")]
        public async Task<IActionResult> Get()
        {
            var todoList = await taskService.GetAllTaskAsync();
            return Ok(todoList);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]TaskRequestModel task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();

            }
            var description = task.Description;
            var edit = task.Edit;
            var done = task.Done;
            taskService.AddTaskAsync(description,done,edit);
            var todoList = await taskService.GetAllTaskAsync();


            return Created("Get", todoList);
        }
        [HttpDelete]
        [Route("{id}")]
        public async  Task<IActionResult> Delete(int id)
        {
            var result = await  taskService.RemoveTask(id);
            if(result == false)
            {
                return BadRequest();
            }
            var todoList = await taskService.GetAllTaskAsync();

            return Ok(todoList);
        }


    }
}
