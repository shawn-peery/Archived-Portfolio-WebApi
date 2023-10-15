using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Portfolio_WebApi.Models.TodoModels
{

    public class CreteTodoDto
    {

        [Required(ErrorMessage = "Please enter a title.")]
        [NotNull]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a description.")]
        [NotNull]
        public string Description { get; set; } = string.Empty;
    }

}