using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapstoneFinal.Models
{
    public class TaskViewModel
    {
        public string Email { get; set; }

        public List<Task> TaskList { get; set; }
    }
}