using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAppServer.Data
{
    public class TaskToDo
    {
        
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]

        public bool Done { get; set; }
        [Required]

        public bool Edit { get; set; }
    }
}
