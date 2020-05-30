using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using TodoAppServer.Data;
using TodoAppServer.Features.Task;
using TodoAppServer.Features.Task.Models;

namespace TodoAppServer.Features.Task
{
    public class TaskService : ITaskService
    {
        private readonly TodoAppDbContext dbContext;

        public TaskService(TodoAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddTask(string description)
        {
            throw new NotImplementedException();
        }

        public void RemoveTask(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaskServiceModel> GetAllTask()
        {

            var data = dbContext.Tasks.ToList();
            //var result = new List<TaskServiceModel>();
            var result = data.Select(x => new TaskServiceModel(){Id = x.Id, Discription = x.Description });
            return result;
        }
    }
}
