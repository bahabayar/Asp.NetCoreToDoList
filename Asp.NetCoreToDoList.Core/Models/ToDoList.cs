using System;
using System.Collections.Generic;
using System.Text;

namespace Asp.NetCoreToDoList.Core.Models
{
    public class ToDoList
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public bool IsDeleted { get; set; }
    }
}
