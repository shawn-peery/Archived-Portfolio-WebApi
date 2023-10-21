using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components.Web;

namespace Portfolio_WebApi.Models.TodoModels
{

    public class CreateTodoDto
    {
        [JsonProperty(nameof(Title))]
        [Required(ErrorMessage = "Please enter a title.")]
        [NotNull]
        public string Title { get; set; }

        [JsonProperty(nameof(Description))]
        [Required(ErrorMessage = "Please enter a description.")]
        [NotNull]
        public string Description { get; set; }

        public CreateTodoDto()
        {

        }
        public CreateTodoDto(string Title, string Description)
        {
            this.Title = Title;
            this.Description = Description;
        }

    }

}