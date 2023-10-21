
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Portfolio_WebApi.Models.TodoModels
{

    public class ViewTodoDto
    {

        [JsonProperty(nameof(Title))]
        public string Title { get; set; }

        [JsonProperty(nameof(Description))]
        public string Description { get; set; }

        public ViewTodoDto()
        {

        }

        public ViewTodoDto(Todo todo)
        {
            this.Title = todo.Title;
            this.Description = todo.Description;
        }

    }

}