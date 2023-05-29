using System.ComponentModel.DataAnnotations;
using TimeMate.Areas.Identity.Data;
#nullable disable

namespace TimeMate.Models
{
    public class LeaveRequest
    {
        public int Id { get; set; }
        [Display(Name = "Employee ID")]
        public string EmployeeId { get; set; } // Add EmployeeId property
        public TimeMateUser Employee { get; set; } // Reference to the ApplicationUser
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public string Reason { get; set; }
        [Required]
        public LeaveStatus Status { get; set; }

        [Display(Name = "Compensatory Date")]
        public DateTime? CompensatoryDate { get; set; }

        [Display(Name = "Manager Approval")]
        public LeaveStatus ManagerApproval { get; set; }

        [Display(Name = "Cancellation Reason")]
        [Required]
        public string CancellationReason { get; set; }


    }
}
