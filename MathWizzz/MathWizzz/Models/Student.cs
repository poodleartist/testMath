using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz.Models
{
    class Student
    {
        public int StudentId { get; set; }
        public int StudentLevel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AverageGrade { get; set; }
    }
}
