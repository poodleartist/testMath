using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz
{
    public class Person
    {
        private string lastName;
        private string firstName;
        private string userRole;
        private string username;
        private string password;

        //Empty contructor
        public Person()
        {

        }
        //Constructor
        public Person(string lName, string fName, string uRole, string uname, string password)
        {
            this.lastName = lName;
            this.firstName = fName;
            this.userRole = uRole;
            this.username = uname;
            this.password = password;
        }
        //Getter and setter for the private proprerties
        public string LastName
        {
            get
            {
                return lastName;

            }
            set
            {
                lastName = value;
            }

        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string UserRole
        {
            get
            {
                return userRole;
            }
            set
            {
                userRole = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;

            }
            set
            {
                password = value;
            }
        }







    }
}
