using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz.Models
{
    // User class to move data object to DB, should be used for login process.
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        // We will want to change this to a hash of some sort.
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // We will need to find a way to make sure this is student and have some way to make the account an admin / teacher.
        public string UserRole {get; set;}
    }
}
