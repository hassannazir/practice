using System;
using System.Collections.Generic;

namespace WebApplication17.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? DOB { get; set; }
    }
}
