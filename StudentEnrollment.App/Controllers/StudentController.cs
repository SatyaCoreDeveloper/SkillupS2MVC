using StudentEnrollment.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentEnrollment.App.Controllers
{    
    public class StudentController: Controller
    {
        private static List<Student> _students = new List<Student>();        

        [HttpGet]        
        public ActionResult StudentsList()
        {
            return View("~/Views/Student/List.cshtml",_students);

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            student.Id = Guid.NewGuid();
            if (ModelState.IsValid)
            {
                _students.Add(student);
                return RedirectToAction(nameof(StudentsList));
            }
            return View();
        }

        [HttpGet]        
        public ActionResult Edit(Guid id)
        {
            var student = _students.Where(s => s.Id == id).SingleOrDefault();
            return View(student);
        }

        [HttpPost]       
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                var oldStudent = _students.Where(s => s.Id == student.Id).SingleOrDefault();
                _students.Remove(oldStudent);
                _students.Add(student);
                return RedirectToAction(nameof(StudentsList));
            }
            return View(student);
        }                  

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            var student = _students.SingleOrDefault(s => s.Id == id);
            _students.Remove(student);
            return RedirectToAction(nameof(StudentsList));
        }
    }
}