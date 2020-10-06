using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class ValidEntry
    {
        private readonly NLog nLog = new NLog();
        public void validateFirstName()
        {
            //Pattern for valid first name
            string firstNamePattern = @"^[A-Z]{1}([a-zA-Z]+){2,}";          
            Regex regex = new Regex(firstNamePattern);
            //User input
            Console.WriteLine("Enter the first name of the user");
            string firstName = Console.ReadLine();
            //IF valid first name
            if(regex.IsMatch(firstName))
            {
                Console.WriteLine("Thank you for entering a valid first name");
                nLog.LogInfo("User entered a valid first name: "+firstName);
            }  
            //If invalid first name
            else
            {
                Console.WriteLine("Invalid first name, must have atleast 3 characters and first letter must be capital");
                nLog.LogError("User entered an invalid first name: "+firstName);
            }
        }
        public void validateLastName()
        {
            //Pattern for valid last name
            string lastNamePattern = @"^[A-Z]{1}([a-zA-Z]+){2,}";
            Regex regex = new Regex(lastNamePattern);
            //User input
            Console.WriteLine("Enter the last name of the user");
            string lastName = Console.ReadLine();
            //IF valid last name
            if (regex.IsMatch(lastName))
            {
                Console.WriteLine("Thank you for entering a valid last name");
                nLog.LogInfo("User entered a valid last name: " + lastName);
            }
            //If invalid last name
            else
            {
                Console.WriteLine("Invalid last name, must have atleast 3 characters and first letter must be capital");
                nLog.LogError("User entered an invalid last name: " + lastName);
            }
        }
        public void validateEmail()
        {
            //Pattern for valid email
            string emailPattern = @"^[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*([@]{1}[a-zA-Z0-9]+)?([.][a-zA-Z]{3})+([.][a-zA-Z]{2})?$";
            Regex regex = new Regex(emailPattern);
            //User input
            Console.WriteLine("Enter the email of the user");
            string email = Console.ReadLine();
            //IF valid email
            if (regex.IsMatch(email))
            {
                Console.WriteLine("Thank you for entering a valid email");
                nLog.LogInfo("User entered a valid email: " + email);
            }
            //If invalid email
            else
            {
                Console.WriteLine("Invalid email:"+email);
                nLog.LogError("User entered an invalid email: " + email);
            }
        }
        public void validateMobileNumber()
        {
            //Pattern for valid mobile number
            string mobileNumberPattern = @"^91[ ][6-9]{1}[0-9]{9}$";
            Regex regex = new Regex(mobileNumberPattern);
            //User input
            Console.WriteLine("Enter the country code and mobile number of the user");
            string mobileNumber = Console.ReadLine().ToString();
            //IF valid mobile number
            if (regex.IsMatch(mobileNumber))
            {
                Console.WriteLine("Thank you for entering a valid mobile number");
                nLog.LogInfo("User entered a valid mobile number: " + mobileNumber);
            }
            //If invalid mobile number
            else
            {
                Console.WriteLine("Invalid mobile number");
                nLog.LogError("User entered an invalid mobile number: " + mobileNumber);
            }
        }
        public void validatePassword()
        {
            //Pattern for valid password
            string passwordPattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&#])[A-Za-z\d@$!%*#?&]{8,}$";
            Regex regex = new Regex(passwordPattern);
            //User input
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine().ToString();
            //IF valid password
            if (regex.IsMatch(password))
            {
                Console.WriteLine("Voila! You entered a strong password");
                nLog.LogInfo("User entered a valid password: " + password);
            }
            //If invalid password
            else
            {
                Console.WriteLine("Invalid password: It must contain at least one each of Upper case, number and special character and must be 8 chars long");
                nLog.LogError("User entered an invalid password: " + password);
            }
        }

    }
}
