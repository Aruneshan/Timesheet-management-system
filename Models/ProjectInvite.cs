using System;
using System.Collections.Generic;
using TimeMate.Areas.Identity.Data;
using TimeMate.Models;
#nullable disable


namespace TimeMate.Models
{
    public partial class ProjectInvite
    {
        public int ProjectId { get; set; }
        public string EmployeeId { get; set; }
        public string Status { get; set; }
        public int InviteId { get; set; }
        public DateTime InviteDate { get; set; }

        public virtual TimeMateUser Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}
