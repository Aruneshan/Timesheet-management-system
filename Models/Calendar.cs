using System.ComponentModel.DataAnnotations;
#nullable disable
namespace TimeMate.Models
{
    public class Calendar
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string DayOfWeek { get; set; }
        public bool IsPublicHoliday { get; set; }
        public string EventDescription { get; set; }
    }

}
