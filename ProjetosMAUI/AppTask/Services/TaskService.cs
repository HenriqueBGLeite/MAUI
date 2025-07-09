using AppTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AppTask.Services
{
    public class TaskService : ITaskService
    {
        private HttpClient _httpClient;

        public TaskService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TaskModel>> GetAll(Guid userId)
        {
            return await _httpClient.GetFromJsonAsync<List<TaskModel>>($"tasks?userId={userId}");
        }

        public async Task Add(TaskModel task)
        {
            await _httpClient.PostAsJsonAsync<TaskModel>("tasks", task);
        }

        public async Task Update(TaskModel task)
        {
            await _httpClient.PutAsJsonAsync<TaskModel>("tasks", task);
        }

        public async Task Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"tasks/{id}");
        }

        public async Task<List<TaskModel>> BatchPush(Guid userId, List<TaskModel> tasks)
        {
            var httpMsg =  await _httpClient.PostAsJsonAsync($"tasks/batchpush/{userId}", tasks);

            if (httpMsg.IsSuccessStatusCode)
            {
                return await httpMsg.Content.ReadFromJsonAsync<List<TaskModel>>();
            }

            throw new HttpRequestException($"Erro ao consumir o BatchPush: {await httpMsg.Content.ReadAsStringAsync()}", null, httpMsg.StatusCode);
        }
    }
}
