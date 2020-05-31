
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoAppServer.Data;
using TodoAppServer.Features.Task.Models;

namespace TodoAppServer.Features.Task
{
    public interface ITaskService
    {
       public  Task<IEnumerable<TaskServiceModel>> GetAllTaskAsync();
        public  void AddTaskAsync(string description);
        public Task<bool> RemoveTask(int id);

    }
}
