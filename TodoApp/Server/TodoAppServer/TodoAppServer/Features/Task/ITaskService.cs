
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoAppServer.Data;
using TodoAppServer.Features.Task.Models;

namespace TodoAppServer.Features.Task
{
    public interface ITaskService
    {
       public IEnumerable<TaskServiceModel> GetAllTask();
        public void AddTask(string description);
        public void RemoveTask(int id);

    }
}
