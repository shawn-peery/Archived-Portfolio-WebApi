using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Portfolio_WebApi.Models.TodoModels;
using System.ComponentModel.DataAnnotations;

namespace Portfolio_WebApi.Models
{
    public class Todo
    {



        public int Id { get; set; }


        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; } = string.Empty;


        [ValidateNever]
        public string User  { get; set; } = string.Empty!;


        [ValidateNever]
        public Status Status { get; set; } = null!;

        public Todo() {

        }
        public Todo(CreteTodoDto createTodoDto) {

            this.Title = createTodoDto.Title;
            this.Description = createTodoDto.Description;

        }

    }
}
