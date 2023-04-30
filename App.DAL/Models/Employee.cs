using System;
using System.Collections.Generic;

namespace App.DAL.Models
{
    public partial class Employee
    {
        public int Idemployee { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }
}
