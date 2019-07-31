using System.Threading.Tasks;
using AspnetCoreTodo.Models;

namespace AspnetCoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemAsync();
    }
}