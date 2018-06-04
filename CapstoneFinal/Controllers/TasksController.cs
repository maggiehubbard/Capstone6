using CapstoneFinal.DAO;
using CapstoneFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapstoneFinal.Controllers
{
    public class TasksController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Search(TaskViewModel model)
        {
            //todo
            model.TaskList = TaskDao.GetTasksByEmail(model.Email);

            return View(model);
        }

        public ActionResult UserTasks(TaskViewModel user)
        {
            user.TaskList = TaskDao.GetTasksByEmail(user.Email);
            return View(user);
        }
    }


}