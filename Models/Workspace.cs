using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TimeMate.Areas.Identity.Data;
using TimeMate.Models;
#nullable disable


namespace TimeMate.Models
{
    public partial class WorkSpace
    {
        [Key]
        public int WorkspaceId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("TimeMateUser")]
        public string PmId { get; set; }
        public TimeMateUser TimeMateUser { get; set; }

    }
}
