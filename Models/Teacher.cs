using System;
using System.Collections.Generic;

namespace WebApplication17.Models
{
    public partial class Teacher
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
    }
}
