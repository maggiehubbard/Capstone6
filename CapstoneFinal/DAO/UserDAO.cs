using CapstoneFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapstoneFinal.DAO
{
    public class UserDAO
    {
        public List<Task> AddNewUser(User user)
        {
            TaskListEntities db = new TaskListEntities();
            
            var listOfTasks = db.Tasks.Where(t => t.UserEmail == user.Email).ToList();

            return listOfTasks;
        }

            
    }
}