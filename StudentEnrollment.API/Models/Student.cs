using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudentEnrollment.App.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        [MinLength(3)]
        [MaxLength(50)]        
        public string Name { get; set; }
        public string Email { get; set; }
    }
}