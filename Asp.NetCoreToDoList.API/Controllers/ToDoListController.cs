using Asp.NetCoreToDoList.API.DTOs;
using Asp.NetCoreToDoList.Core.Models;
using Asp.NetCoreToDoList.Core.Services;
using AutoMapper;
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
        private readonly IMapper _mapper;
        public ToDoListController(IService<ToDoList> toDoListService,IMapper mapper)
        {
            _toDoListService = toDoListService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var toDoLists = await _toDoListService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ToDoListDTO>>(toDoLists));
        }
        [HttpGet("{id}")]
        public async Task <IActionResult> GetById(int id) 
        {
            var toDo = await _toDoListService.GetByIdAsync(id);
            return Ok(_mapper.Map<ToDoListDTO>(toDo));
        }
        [HttpPost]
        public async Task<IActionResult> Save(ToDoList toDoList)
        {
            var newToDoList = await _toDoListService.AddAsync(toDoList);
            return Created(string.Empty,_mapper.Map<ToDoList>(newToDoList));
        }
        [HttpPut]
    }
}
