using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication17.Models;

namespace WebApplication17.Controllers
{
    public class FirstController : Controller
    {
        NDBContext ORM=null;
        public FirstController(NDBContext _ORM)
        {
            ORM = _ORM;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
       public IActionResult AddNewStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewStudent(Student S)
        {
            ORM.Student.Add(S);
            ORM.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult AddNewTeacher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewTeacher(Teacher T)
        {
            ORM.Teacher.Add(T);
            ORM.SaveChanges();
            return View();
        }

        public IActionResult AllStudents()
        {
            return View(ORM.Student.ToList());
        }

        public IActionResult DeleteStudent(int id)
        {
           var obj= ORM.Student.Find(id);
            ORM.Student.Remove(obj);
            ORM.SaveChanges();
            return RedirectToAction("AllStudents");
        }

        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            var obj = ORM.Student.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult EditStudent(Student S)
        {
            ORM.Student.Update(S);
            ORM.SaveChanges();
            return RedirectToAction("AllStudents");

        }

        public IActionResult StudentDetail(int id)
        {
            return View(ORM.Student.Find(id));
        }
    }
}