using System;
using System.Collections.Generic;
using System.Linq;
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

        [HttpGet]
        public IActionResult Get()
        {
           var result = taskService.GetAllTask();

            return Ok(result);
          
        }
        [HttpPost]
        public IActionResult Post(TaskRequestModel task)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
               // return new HttpStatusCodeResult((HttpStatusCode)422,
               //"My custom internal server error.");
            }
            

            return Ok("minava");

        }


    }
}
