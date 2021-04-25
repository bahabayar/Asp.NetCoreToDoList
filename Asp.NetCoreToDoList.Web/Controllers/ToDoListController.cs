using Asp.NetCoreToDoList.Web.ApiService;
using Asp.NetCoreToDoList.Web.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreToDoList.Web.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly ToDoListApiService _toDoListApiService;
        private readonly IMapper _mapper;
        public ToDoListController(ToDoListApiService toDoListApiService, IMapper mapper)
        {
            _toDoListApiService = toDoListApiService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var todolists = await _toDoListApiService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<ToDoListDTO>>(todolists));

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ToDoListDTO toDoListDTO)
        {
            await _toDoListApiService.AddAsync(toDoListDTO);
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Update(int id)
        {
            var todolist = await _toDoListApiService.GetByIdAsync(id);
            return View(_mapper.Map<ToDoListDTO>(todolist));
        }
        [HttpPost]
        public async Task<IActionResult> Update(ToDoListDTO toDoListDTO)
        {
            await _toDoListApiService.Update(toDoListDTO);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _toDoListApiService.Remove(id);
            return RedirectToAction("Index");
        }
    }

}
