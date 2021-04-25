using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreToDoList.Web.DTOs
{
    public class ToDoListDTO
    {
        [Required]
        public int Id { get; set; }
        public string  TaskName { get; set; }
        public string TaskDescription { get; set; }
    }
}
