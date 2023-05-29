using System.ComponentModel.DataAnnotations;
#nullable disable
namespace TimeMate.Models
{
    public class GoalSetting
    {
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(255)]
            public string Description { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
            public DateTime? DueDate { get; set; }

            public bool IsComplete { get; set; }

            public string AssignedTo { get; set; }
        public string AssignedBy { set; get; }

    }
}
