using Microsoft.AspNetCore.Mvc;
using Portfolio_WebApi.Models;
using Portfolio_WebApi.Models.ResponseModels;
using Portfolio_WebApi.Models.TodoModels;

namespace Portfolio_WebApi.Services
{

    public interface ITodoService
    {
        ReturnModelWithMessageDto<ViewTodoDto> CreateTodo(CreateTodoDto newTodo);
    }
    public class TodoService : ITodoService
    {

        private TodoContext todoContext;

        public TodoService(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }
        public ReturnModelWithMessageDto<ViewTodoDto> CreateTodo(CreateTodoDto createTodoDto)
        {

            if (createTodoDto.Title == "")
            {
                throw new BadHttpRequestException("Please provide a title.");
            }

            if (createTodoDto.Description == "")
            {
                throw new BadHttpRequestException("Please provide a description.");
            }

            Todo newTodo = new Todo(createTodoDto);

            todoContext.ToDos.Add(newTodo);

            todoContext.SaveChanges();

            ViewTodoDto viewTodoDto = new ViewTodoDto(newTodo);

            ReturnModelWithMessageDto<ViewTodoDto> returnModelDto = new("Successfully created new TodoDto!", viewTodoDto);

            return returnModelDto;

        }

    }
}