using CapstoneFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapstoneFinal.DAO
{
    public class TaskDao
    {
        public static List<Task> GetTasksByEmail(string email)
        {
            TaskListEntities db = new TaskListEntities();

            var user = db.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
            {
                return null;
            }

            var listOfTasks = db.Tasks.Where(t => t.UserEmail == user.Email).ToList();

            return listOfTasks;
        }
    }
}