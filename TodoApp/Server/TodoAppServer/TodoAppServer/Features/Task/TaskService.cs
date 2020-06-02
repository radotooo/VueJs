using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
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

        public async void AddTaskAsync(string description,bool done , bool edit)
        {
           var  task = new TaskToDo(){ Description = description , Done = done, Edit = edit };
            dbContext.Tasks.Add(task);
           await dbContext.SaveChangesAsync();
           
        }

        public async Task<bool> RemoveTask(int id)
        {
            var task = dbContext.Tasks.Find(id);
            if(task == null)
            {
                return false;
            }

            dbContext.Tasks.Remove(task);
              await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<TaskServiceModel>> GetAllTaskAsync()
        {

            var data = await dbContext.Tasks.ToListAsync();
            //var result = new List<TaskServiceModel>();
            var result = data.Select(x => new TaskServiceModel(){Id = x.Id, Discription = x.Description , Done = x.Done , Edit = x.Edit});
            return result;
        }
    }
}
