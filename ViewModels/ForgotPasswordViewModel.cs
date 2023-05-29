using System.ComponentModel.DataAnnotations;

namespace TimeMate.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "SMTP Server")]
        public string SmtpServer { get; set; }

        [Required]
        [Display(Name = "SMTP Port")]
        public int SmtpPort { get; set; }

        [Required]
        [Display(Name = "SMTP Username")]
        public string SmtpUsername { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "SMTP Password")]
        public string SmtpPassword { get; set; }
    }

}
