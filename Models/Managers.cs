using System;
using System.Collections.Generic;
using TimeMate.Areas.Identity.Data;
using TimeMate.Models;
#nullable disable

namespace TimeMate.Models
{
    public partial class Managers
    {
        public Managers()
        {
            InverseManager = new HashSet<Managers>();
        }

        public string EmployeeId { get; set; }
        public string ManagerId { get; set; }

        public virtual TimeMateUser Employee { get; set; }
        public virtual Managers Manager { get; set; }
        public virtual ICollection<Managers> InverseManager { get; set; }
    }
}
