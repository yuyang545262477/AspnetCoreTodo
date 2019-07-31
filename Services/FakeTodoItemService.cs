using System;
using System.Threading.Tasks;
using AspnetCoreTodo.Models;

namespace AspnetCoreTodo.Services
{
    public class FakeTodoItemService:ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };

            var item2 = new TodoItem
            {
                Title = "Build ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };

            return Task.FromResult(new[] {item1, item2});
        }
        }
    
}