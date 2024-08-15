using Newtonsoft.Json;
using System.Net.Http;
using TestWeek7.Models;

namespace TestWeek7.Services
{
    public class TodosService : HttpClient
    {
        private readonly HttpClient _httpClient;

        public TodosService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Todos>> GetAllTodosAsync()
        {
            var response = await _httpClient.GetAsync("https://dummyjson.com/todos");
            var json = await response.Content.ReadAsStringAsync();
            var todos = JsonConvert.DeserializeObject<List<Todos>>(json);
            return todos;
        }
    }
}
