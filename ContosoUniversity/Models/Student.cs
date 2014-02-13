using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        // Primary Key, EF treats ID or classID as primary key by its own.
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Enrollments is the Navigation Property. Hold Enrollment Entity with Student.
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}