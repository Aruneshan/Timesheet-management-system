#nullable disable
using System.ComponentModel.DataAnnotations;
namespace TimeMate.ViewModels
{
    public class CreateTaskViewModel
    {
        [Display(Name = "Task Name")]
        [Required]
        public string TaskName { get; set; }
    }
}
