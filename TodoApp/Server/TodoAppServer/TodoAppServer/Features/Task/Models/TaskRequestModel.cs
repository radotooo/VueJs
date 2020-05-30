

using System.ComponentModel.DataAnnotations;
using static TodoAppServer.Data.Validation.Task;

namespace TodoAppServer.Features.Task.Models
{
    public class TaskRequestModel
    {
        [Required(ErrorMessage = InputIsRequaried)]
        public string Description { get; set; }
    }
}
