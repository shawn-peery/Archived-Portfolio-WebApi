using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Portfolio_WebApi.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; } = string.Empty;

        [ValidateNever]
        public Status Status { get; set; } = null!;

    }
}
