using Asp.NetCoreToDoList.Web.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Asp.NetCoreToDoList.Web.ApiService
{
    public class ToDoListApiService
    {
        private readonly HttpClient _httpClient;
        public ToDoListApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<ToDoListDTO>> GetAllAsync()
        {
            IEnumerable<ToDoListDTO> toDoListDTOs;
            var response = await _httpClient.GetAsync("todolist");
            if (response.IsSuccessStatusCode)
            {
                toDoListDTOs = JsonConvert.DeserializeObject<IEnumerable<ToDoListDTO>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                toDoListDTOs = null;
            }
            return toDoListDTOs;

        }
    }
}
