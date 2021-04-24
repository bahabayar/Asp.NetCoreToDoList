using Asp.NetCoreToDoList.API.DTOs;
using Asp.NetCoreToDoList.Core.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreToDoList.API.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<ToDoList, ToDoListDTO>();
            CreateMap<ToDoListDTO, ToDoList>();
           
        }
    }
}
