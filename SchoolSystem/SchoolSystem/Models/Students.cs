using System;
using System.Collections.Generic;
using System.Data.Entity;
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

    public class StudentDBContext : DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
    }
}