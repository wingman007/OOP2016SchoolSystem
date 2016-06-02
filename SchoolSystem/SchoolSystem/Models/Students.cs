using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSystem.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string Grade { get; set; }
        public int Number { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public virtual Grades Grades { get; set; }

    }
}