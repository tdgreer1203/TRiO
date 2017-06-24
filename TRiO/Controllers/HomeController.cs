using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRiO.ViewModels;
using TRiO.Controllers;
using TRiO.Models;

namespace TRiO.Controllers
{
    [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        private IEnumerable<Session> sessions;

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
            if (String.IsNullOrEmpty(id))
                return PartialView($"_Failed");
            else
            {
                int identifier = Int32.Parse(id, NumberStyles.Integer);
                var student = _context.Students.FirstOrDefault(m => m.StudentId == id || m.CardNumber == id);

                if (student != null)
                {
                    sessions = _context.Sessions;

                    var session = _context.Sessions.FirstOrDefault(m => m.StudentId == student.Id && m.EndTime == m.StartTime);

                    if (session != null)
                    {
                        //Sign the Student out.
                        session.EndTime = DateTime.Now;
                        _context.SaveChanges();

                        return PartialView($"_LoggedOut");
                    }
                    else
                    {
                        //Sign the student in.
                        var newSession = new Session();
                        newSession.StartTime = DateTime.Now;
                        newSession.EndTime = newSession.StartTime;
                        newSession.StudentId = student.Id;
                        newSession.LabId = 1;

                        _context.Sessions.Add(newSession);
                        _context.SaveChanges();

                        return PartialView($"_LoggedIn");
                    }
                }
                else
                {
                    return PartialView($"_Failed");
                }
            }
        }
    }
}