using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph;
using Microsoft.OpenApi.Expressions;
using Portfolio_WebApi.Models.ResponseModels;
using Portfolio_WebApi.Models.TodoModels;
using Portfolio_WebApi.Services;

namespace Portfolio_WebApi.Controllers
{
    // [ApiController]
    public class TodoController : ControllerBase
    {

        private ITodoService todoService;

        public TodoController(ITodoService todoService)
        {
            this.todoService = todoService;
        }


        [Authorize(Roles = Roles.ADMIN_ROLE)]
        [HttpPost]
        public ActionResult<ReturnModelWithMessageDto<ViewTodoDto>> CreateTodo(CreteTodoDto newTodo)
        {
            ActionResult<ReturnModelWithMessageDto<ViewTodoDto>> response;
            try
            {
                response = todoService.CreateTodo(newTodo);
            }
            catch (BadHttpRequestException exception)
            {
                return BadRequest(exception.Message);
            }

            return response;

        }

    }
}
