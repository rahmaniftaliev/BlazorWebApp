using Blazor.Models;

namespace Blazor.Services
{
    public interface IApiService
    {
        Task<TodoItem[]> GetTodos();
    }
}
