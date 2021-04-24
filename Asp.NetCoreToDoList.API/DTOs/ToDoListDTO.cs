using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreToDoList.API.DTOs
{
    public class ToDoListDTO
    {
        [Required]
        public string  TaskName { get; set; }
        public string TaskDescription { get; set; }
    }
}
