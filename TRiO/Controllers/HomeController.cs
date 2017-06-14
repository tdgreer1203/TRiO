using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRiO.ViewModels;
using TRiO.Models;

namespace TRiO.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateSession(string id)
        {
            var isRegisteredStudent = _context.Students.Where(m => m.StudentId == id || m.CardNumber == id).FirstOrDefault();

            if (isRegisteredStudent != null)
            {
                //Sign student in.
                return PartialView("_Success");
            }
            else
            {
                ModelState.Clear();
                return PartialView("_Failed");
            }
        }
    }
}