using Blazor.Models;
using System.Net.Http;
using System.Net.Http.Json;


namespace Blazor.Services
{
    public class JsonPlaceHolderApi:IApiService
    {
        private HttpClient _httpClient;

        public JsonPlaceHolderApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<TodoItem[]> GetTodos()
        {
            return await _httpClient.GetFromJsonAsync<TodoItem[]>(
                "https://jsonplaceholder.typicode.com/todos"
            ) ?? [];
        }
    }
}
