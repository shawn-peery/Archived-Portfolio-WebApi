using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph;
using Microsoft.OpenApi.Expressions;
using Portfolio_WebApi.Models.ResponseModels;
using Portfolio_WebApi.Models.TodoModels;
using Portfolio_WebApi.Services;
using Portfolio_WebApi.Utils;

namespace Portfolio_WebApi.Controllers
{
    [ApiController]
    [Route(RouteUtil.STANDARD_ROUTE)]
    public class TodoController : ControllerBase
    {

        private ITodoService todoService;

        public TodoController(ITodoService todoService)
        {
            this.todoService = todoService;
        }


        [Authorize(Roles = Roles.ADMIN_ROLE)]
        [HttpPost]
        public ReturnModelWithMessageDto<ViewTodoDto> CreateTodo(CreateTodoDto newTodo)
        {

            // Access the Azure Object ID from the User's claims
            string? azureObjectId = User.FindFirst("http://schemas.microsoft.com/identity/claims/objectidentifier")?.Value;



            ReturnModelWithMessageDto<ViewTodoDto> response;
            try
            {
                response = todoService.CreateTodo(newTodo);
            }
            catch (BadHttpRequestException exception)
            {
                return new("", new());
                // return BadRequest(exception.Message);
            }

            return response;

        }
    }
}
