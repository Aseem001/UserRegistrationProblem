using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {           
            ValidEntry validEntry = new ValidEntry();
            Console.WriteLine("Welcome to User registration portal!");
           //Validation for first name
            validEntry.validateFirstName();
            //Validation for last name
            validEntry.validateLastName();
            //Validation for email
            validEntry.validateEmail();
            //Validation for mobile number
            validEntry.validateMobileNumber();
        }
    }
}
