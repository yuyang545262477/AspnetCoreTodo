using System.Threading.Tasks;
using AspnetCoreTodo.Models;
using AspnetCoreTodo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var items = await _todoItemService.GetIncompleteItemAsync();
            var model = new TodoViewModel
            {
                Items = items
            };
            
            return View(model);
            //从数据库中,获取to-do条目
            //从条目置于model中
            //使用Model渲染试图
        }
        
        
    }
}