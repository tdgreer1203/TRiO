using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRiO.ViewModels;
using TRiO.Models;

namespace TRiO.Controllers
{
    [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
    public class RegisterController : Controller
    {
        private ApplicationDbContext _context;
        private IEnumerable<Student> students;

        public RegisterController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Register
        public ActionResult Index()
        {
            students = _context.Students;
            return View();
        }

        public ActionResult CreateStudent(string fn, string mi, string ln, string email, string phone, string id, string cn)
        {
            students = _context.Students;

            if(String.IsNullOrEmpty(fn) || String.IsNullOrEmpty(ln) || String.IsNullOrEmpty(email) || string.IsNullOrEmpty(id))
            {
                return PartialView($"_FailedBlank");
            }
            else if(students.Any(s => s.StudentId == id || s.CardNumber == cn))
            {
                return PartialView($"_FailedAccount");
            }
            else
            {
                var student = new Student();
                student.FirstName = fn;
                student.MiddleInitial = mi;
                student.LastName = ln;
                student.Email = email;
                student.Phone = phone;
                student.StudentId = id;
                student.CardNumber = cn;

                _context.Students.Add(student);
                _context.SaveChanges();

                return PartialView($"_Success");
            }
        }

        public Student GetStudent(string id)
        {
            students = _context.Students;
            var student = _context.Students.FirstOrDefault(m => m.StudentId == id || m.CardNumber == id);

            return student;
        }
    }
}