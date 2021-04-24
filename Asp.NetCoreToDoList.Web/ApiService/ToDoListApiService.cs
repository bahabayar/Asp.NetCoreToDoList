using Asp.NetCoreToDoList.Web.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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
        public async Task<ToDoListDTO> AddAsync(ToDoListDTO toDoListDTO)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(toDoListDTO), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("todolist",stringContent);
            if (response.IsSuccessStatusCode)
            {
                toDoListDTO = JsonConvert.DeserializeObject<ToDoListDTO>(await response.Content.ReadAsStringAsync());
                return toDoListDTO;
            }
            else
            {
                return null;
            }
        }
        public async Task<ToDoListDTO> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"todolist/{id}");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ToDoListDTO>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }
        public async Task<bool> Update(ToDoListDTO toDoListDTO)
        {

            var stringContent = new StringContent(JsonConvert.SerializeObject(toDoListDTO), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync("todolist", stringContent);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> Remove(int id)
        {
            var response = await _httpClient.DeleteAsync($"todolist/{id}");
            if (response.IsSuccessStatusCode)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
