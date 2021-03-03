using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz
{
    public class Student : Person
    {
        //Student ID properties
        public int studentID;
        public int studentLevel;
        public int classID;
        //Empty Constructor
        public Student()
        {

        }
        // Constructor uses super class.
        //I did not added student level to the constructor because this properties is generated when the student
        // take the placement test and will determine the student level.

        public Student(string lastName, string firstName, string userRole, string username,
            string password, int studentID, int classID) : base(lastName, firstName, userRole, username, password)
        {
            this.studentID = studentID;
            this.classID = classID;
        }

        //Getter and setter for the student id
        public int StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }

        //Getter and setter for the student level
        public int StudentLevel
        {
            get
            {
                return studentLevel;
            }
            set
            {
                studentLevel = value;
            }
        }

        //Getter and setter for the class ID
        public int ClassID
        {
            get
            {
                return classID;
            }
            set
            {
                classID = value;
            }
        }


    }

}
