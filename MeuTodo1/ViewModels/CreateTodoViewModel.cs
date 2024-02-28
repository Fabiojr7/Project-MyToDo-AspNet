using System.ComponentModel.DataAnnotations;

namespace MeuTodo1.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title { get; set;}
    }
}