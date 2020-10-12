using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationProblem
{
    class UserDetails
    {
        public string firstName;
        public string lastName;
        public string email;
        public string mobileNumber;
        public string password;

        public UserDetails(string firstName, string lastName, string email, string mobileNumber, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.mobileNumber = mobileNumber;
            this.password = password;
        }
    }
}
