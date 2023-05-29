using System.ComponentModel.DataAnnotations;

namespace TimeMate.Models
{
    public class DateTimeRangeViewModel
    {
        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Please enter a start date.")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "Please enter an end date.")]
        public DateTime EndDate { get; set; }
    }
}
