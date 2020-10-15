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

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDetails"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="email">The email.</param>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <param name="password">The password.</param>
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
