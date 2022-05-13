
using IdintityProject.Models;
using IdintityProject.ViewModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;


namespace IdintityProject.Controllers
{
    public class DashboardController : Controller
    {
        private ApplicationDbContext db;

        public DashboardController()
        {
            db = new ApplicationDbContext();
        }

        // GET: Admin
        [Authorize(Roles = "Admins,Teachers,Students")]

        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admins,Teachers,Students")]

        public ActionResult Profile()
        {
          
            ViewBag.user = User.Identity.GetUserName();
            return View();
        }

         public ActionResult StudentCertificate()
        {
            var user = User.Identity.GetUserName();

            return View();
        }




    }
}
