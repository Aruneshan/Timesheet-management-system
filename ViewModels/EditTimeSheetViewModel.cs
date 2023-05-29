#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeMate.ViewModels
{
    public class EditTimeSheetViewModel
    {
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Task { get; set; }
        public string TaskType { get; set; }
        public int HoursSpent { get; set; }
    }
}
