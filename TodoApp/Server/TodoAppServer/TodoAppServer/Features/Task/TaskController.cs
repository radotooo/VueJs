
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
            var result = await taskService.GetAllTaskAsync();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Post(TaskRequestModel task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();

            }
            var description = task.Description;
            taskService.AddTaskAsync(description);

            return Created("Get", task);
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
            return Ok();
        }


    }
}
