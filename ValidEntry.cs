﻿using System;
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
    }
}
