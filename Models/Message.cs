using System.ComponentModel.DataAnnotations;
#nullable disable
namespace TimeMate.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Subject { get; set; }

        [Required]
        [StringLength(5000)]
        public string Body { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime SentDate { get; set; }

        [StringLength(255)]
        public string SenderEmail { get; set; }

        [Required]
        [StringLength(255)]
        public string RecipientEmail { get; set; }

        public bool IsRead { get; set; }

        public bool IsArchived { get; set; }
    }

}
