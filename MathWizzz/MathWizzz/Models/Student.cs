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
        public int studentLevel;
        public int classID;
        //Empty Constructor
        public Student()
        {

        }
        // Constructor uses super class.
        //I did not added student level to the constructor because this properties is generated when the student
        // take the placement test and will determine the student level.

        public Student(string usrId,string lastName, string firstName, string userRole, string username,
            string password, int classID) : base(usrId,lastName, firstName, userRole, username, password)
        {
            this.classID = classID;
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
