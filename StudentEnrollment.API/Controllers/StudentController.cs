using StudentEnrollment.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentEnrollment.API.Controllers
{
    public class StudentController: System.Web.Http.ApiController
    {
        private static List<Student> _students = new List<Student>();

        public StudentController()
        {
            _students.Add(new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Student1",
                Email = "Student1@IIT.com"                

            });
            _students.Add(new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Student2",
                Email = "Student2@IIT.com"

            });
        }
        
        [HttpGet]
        public IEnumerable<Student> GetAllStudents()
        {
            return _students;
        }

        [HttpPost]
        public string AddStudent(Student student)
        {
            if(ModelState.IsValid)
            {
                _students.Add(student);
                return "Student Succesfully created";
            }
            return "Invalid Student details";
        }

        [HttpDelete]
        public string DeleteStudent(Guid Id)
        {
            return "Student Deleted";
        }
    }
}