using Asp.NetCoreToDoList.Core.Models;
using Asp.NetCoreToDoList.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreToDoList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly IService<ToDoList> _toDoListService;

        public ToDoListController(IService<ToDoList> toDoListService)
        {
            _toDoListService = toDoListService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var toDoLists = await _toDoListService.GetAllAsync();
            return Ok(toDoLists);
        }
        [HttpGet("{id}")]
        public async Task <IActionResult> GetById(int id) 
        {
            var toDo = await _toDoListService.GetByIdAsync(id);
            return Ok(toDo);
        }
        [HttpPost]
        public async Task<IActionResult> Save(ToDoList toDoList)
        {
            var newToDoList = await _toDoListService.AddAsync(toDoList);
            return Ok(newToDoList);
        }
    }
}
