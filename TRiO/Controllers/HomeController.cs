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

        [HttpPost]
        public ActionResult CreateSession(HomeViewModel viewModel)
        {
            var isRegisteredStudent = _context.Students.Where(m => m.StudentId == viewModel.Id || m.CardNumber == viewModel.Id).FirstOrDefault();

            if (isRegisteredStudent != null)
            {
                viewModel.accountFound = true;
                return View("Index", viewModel);
            }
            else
            {
                ModelState.Clear();
                viewModel.accountFound = false;
                return View("Index", viewModel);
            }
        }
    }
}