﻿using Microsoft.EntityFrameworkCore;
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

        public async void AddTaskAsync(string description, bool done)
        {
            var task = new TaskToDo() { Description = description, Done = done};
            dbContext.Tasks.Add(task);
            await dbContext.SaveChangesAsync();

        }

        public async Task<bool> RemoveTask(int id)
        {
            var task = dbContext.Tasks.Find(id);
            if (task == null)
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
            var result = data.Select(x => new TaskServiceModel() { Id = x.Id, Discription = x.Description, Done = x.Done  });
            return result;
        }

        public async Task<TaskToDo> GetTaskAsync(int id)
        {
            var data = await dbContext.Tasks.FirstOrDefaultAsync(x => x.Id == id);
            return data;
        }

        public async void UpdateTaskAsync(bool state, int id)
        {
            var data = await GetTaskAsync(id);

            if (data.Done != state)
            {
                data.Done = state;
            }
            await dbContext.SaveChangesAsync();
        }
    }
}
