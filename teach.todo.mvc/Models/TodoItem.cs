using System.ComponentModel.DataAnnotations;

namespace teach.todo.mvc.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        // These [] elements are called Validation Attributes
        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters")]
        public string Title { get; set; } = string.Empty;
        public bool IsComplete { get; set; }
    }
}
