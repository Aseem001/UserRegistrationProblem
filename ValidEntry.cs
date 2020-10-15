using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class ValidEntry
    {
        private readonly NLog nLog = new NLog();
        private readonly List<UserDetails> userDetailsList = new List<UserDetails>();

        /// <summary>
        /// Validates the first name of the or last.
        /// </summary>
        /// <returns></returns>
        public string ValidateFirstOrLastName()
        {
            //Pattern for valid first or last name
            string firstOrLastNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";          
            Regex regex = new Regex(firstOrLastNamePattern);
            while(true)
            {
                //User input        
                string firstOrLastName = Console.ReadLine();
                //IF valid first or last name
                if (regex.IsMatch(firstOrLastName))
                {
                    Console.WriteLine("Thank you for entering a valid name");
                    nLog.LogInfo("User entered a valid name: " + firstOrLastName);
                    return firstOrLastName;                    
                }
                //If invalid first or last name
                else
                {
                    Console.WriteLine("Invalid name! Enter again: must have atleast 3 characters and first letter must be capital");
                    nLog.LogError("User entered an invalid name: " + firstOrLastName);                    
                }
            }           
        }

        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <returns></returns>
        public string ValidateEmail()
        {
            //Pattern for valid email
            string emailPattern = @"^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.][a-zA-Z]{3})+([.][a-zA-Z]{2})?$";
            Regex regex = new Regex(emailPattern);
            while(true)
            {
                //User input
                Console.WriteLine("Enter the email of the user");
                string email = Console.ReadLine();
                //IF valid email
                if (regex.IsMatch(email))
                {
                    Console.WriteLine("Thank you for entering a valid email");
                    nLog.LogInfo("User entered a valid email: " + email);
                    return email;
                }
                //If invalid email
                else
                {
                    Console.WriteLine("Invalid email:" + email);
                    nLog.LogError("User entered an invalid email: " + email);
                }
            }           
        }

        /// <summary>
        /// Validates the mobile number.
        /// </summary>
        /// <returns></returns>
        public string ValidateMobileNumber()
        {
            //Pattern for valid mobile number
            //string mobileNumberPattern = @"^91[ ][6-9]{1}[0-9]{9}$";
            string mobileNumberPattern = @"^[0-9]{2}[ ][0-9]{10}$";
            Regex regex = new Regex(mobileNumberPattern);
            while(true)
            {
                //User input
                Console.WriteLine("Enter the country code and mobile number of the user");
                string mobileNumber = Console.ReadLine().ToString();
                //IF valid mobile number
                if (regex.IsMatch(mobileNumber))
                {
                    Console.WriteLine("Thank you for entering a valid mobile number");
                    nLog.LogInfo("User entered a valid mobile number: " + mobileNumber);
                    return mobileNumber;
                }
                //If invalid mobile number
                else
                {
                    Console.WriteLine("Invalid mobile number");
                    nLog.LogError("User entered an invalid mobile number: " + mobileNumber);
                }
            }            
        }

        /// <summary>
        /// Validates the password.
        /// </summary>
        /// <returns></returns>
        public string ValidatePassword()
        {
            //Pattern for valid password       
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
            Regex regex = new Regex(passwordPattern);
            while(true)
            {
                //User input
                Console.WriteLine("Enter the password");
                string password = Console.ReadLine().ToString();
                //IF valid password
                if (regex.IsMatch(password))
                {
                    Console.WriteLine("Voila! You entered a strong password");
                    nLog.LogInfo("User entered a valid password: " + password);
                    return password;
                }
                //If invalid password
                else
                {
                    Console.WriteLine("Invalid password: It must contain at least one each of Upper case, number and special character and must be 8 chars long");
                    nLog.LogError("User entered an invalid password: " + password);
                }
            }            
        }

        /// <summary>
        /// Registers the user details.
        /// </summary>
        public void RegisterUserDetails()
        {
            Console.WriteLine("Enter a valid first name:");
            string firstName = ValidateFirstOrLastName();
            Console.WriteLine("Enter a valid last name:");
            string lastName = ValidateFirstOrLastName();
            string email = ValidateEmail();
            string mobileNumber = ValidateMobileNumber();
            string password=ValidatePassword();
            UserDetails userDetails = new UserDetails(firstName, lastName, email, mobileNumber, password);
            userDetailsList.Add(userDetails);
            Console.Clear();
            Console.WriteLine("User Details:");
            foreach(var v in userDetailsList)
            {
                Console.WriteLine("First Name: "+v.firstName+"\nLast Name: "+v.lastName+"\nEmail: "+v.email+"\nMobile Number: "+v.mobileNumber+"\nPassword: "+v.password);
            }            
        }

        /// <summary>
        /// Checks the given email samples to give valid and invalid emails out.
        /// </summary>
        public void CheckEmailSamples()
        {
            string[] samples = {"abc@yahoo.com","abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com",
            "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc",
            "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com",
            "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a",
            "abc@gmail.com.aa.au" };            
            string emailPattern = @"^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+([.][a-zA-Z]{3})+([.][a-zA-Z]{2})?$";
            Regex regex = new Regex(emailPattern);
            foreach(var sample in samples)
            {
                if (regex.IsMatch(sample))
                {
                    Console.WriteLine("Valid Email: "+sample);                   
                }
                else
                {
                    Console.WriteLine("Invalid email:" + sample);                                      
                }
            }                        
        }

        /// <summary>
        /// Returns true if ... the pattern and userValue matches
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="userValue">The user value.</param>
        /// <returns>
        ///   <c>true</c> if the specified pattern is valid; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="UserRegistrationCustomException">Exception: Invalid Details Entered</exception>
        public bool IsValid(string pattern,string userValue)
        {            
            if (Regex.IsMatch(userValue, pattern))
                return true;
            else
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_DETAILS, "Exception: Invalid Details Entered");               
            }                           
        }
    }
}
