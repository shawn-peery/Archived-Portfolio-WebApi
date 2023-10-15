
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Portfolio_WebApi.Models.TodoModels {

    public class ViewTodoDto {

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ViewTodoDto() {

        }

        public ViewTodoDto(Todo todo) {
            this.Title = todo.Title;
            this.Description = todo.Description;
        }

    }

}