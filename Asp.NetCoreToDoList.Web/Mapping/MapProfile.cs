
using Asp.NetCoreToDoList.Core.Models;
using Asp.NetCoreToDoList.Web.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreToDoList.Web.Mapping
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
