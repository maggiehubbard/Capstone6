using CapstoneFinal.DAO;
using CapstoneFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapstoneFinal.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register(User user)
        {
            TaskListEntities db = new TaskListEntities();
            if (ModelState.IsValid)
            {
                try
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    ViewBag.Message = $"Welcome {user.Name}! ";
                    return View(user);
                }
                catch (Exception e)
                {
                    ViewBag.Message = $"Error: {e.Message}";
                    return View(user);
                }
                finally
                {
                    View ("/Tasks/UserTasks");
                    ViewBag.Message = $"Welcome {user.Name}! ";
                }
            }
            ViewBag.Message = $"Welcome {user.Name}! ";
            return View();
        }

        
        public ActionResult Login(User model)
        {
            TaskListEntities db = new TaskListEntities();
            var userRecord = db.Users.FirstOrDefault(u => u.Email == model.Email);

            if (model == null)
            {
                ViewBag.Message = $"Error {model.Email} was not recognized";
            }
            else
            {
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return View();
        }
    }
}