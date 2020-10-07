using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class ValidEntry
    {
        private readonly NLog nLog = new NLog();
         public List<UserDetails> userDetailsList = new List<UserDetails>();
        public string validateFirstName()
        {
            //Pattern for valid first name
            string firstNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";          
            Regex regex = new Regex(firstNamePattern);
            //User input
        Label: Console.WriteLine("Enter the first name of the user");
            string firstName = Console.ReadLine();
            //IF valid first name
            if(regex.IsMatch(firstName))
            {
                Console.WriteLine("Thank you for entering a valid first name");                
                nLog.LogInfo("User entered a valid first name: "+firstName);
                return firstName;
            }  
            //If invalid first name
            else
            {
                Console.WriteLine("Invalid first name, must have atleast 3 characters and first letter must be capital");
                nLog.LogError("User entered an invalid first name: "+firstName);
                goto Label;
            }
        }
        public string validateLastName()
        {
            //Pattern for valid last name
            string lastNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regex = new Regex(lastNamePattern);
            //User input
           Label: Console.WriteLine("Enter the last name of the user");
            string lastName = Console.ReadLine();
            //IF valid last name
            if (regex.IsMatch(lastName))
            {
                Console.WriteLine("Thank you for entering a valid last name");
                nLog.LogInfo("User entered a valid last name: " + lastName);
                return lastName;
            }
            //If invalid last name
            else
            {
                Console.WriteLine("Invalid last name, must have atleast 3 characters and first letter must be capital");
                nLog.LogError("User entered an invalid last name: " + lastName);
                goto Label;
            }
        }
        public string validateEmail()
        {
            //Pattern for valid email
            string emailPattern = @"^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.][a-zA-Z]{3})+([.][a-zA-Z]{2})?$";
            Regex regex = new Regex(emailPattern);
            //User input
          Label:  Console.WriteLine("Enter the email of the user");
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
                Console.WriteLine("Invalid email:"+email);
                nLog.LogError("User entered an invalid email: " + email);
                goto Label;
            }
        }
        public string validateMobileNumber()
        {
            //Pattern for valid mobile number
            string mobileNumberPattern = @"^91[ ][6-9]{1}[0-9]{9}$";
            Regex regex = new Regex(mobileNumberPattern);
            //User input
            Label: Console.WriteLine("Enter the country code and mobile number of the user");
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
                goto Label;
            }
        }
        public string validatePassword()
        {
            //Pattern for valid password       
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
            Regex regex = new Regex(passwordPattern);
            //User input
          Label:  Console.WriteLine("Enter the password");
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
                goto Label;
            }
        }
        public void registerUserDetails()
        {
            string firstName = validateFirstName();
            string lastName = validateLastName();
            string email = validateEmail();
            string mobileNumber = validateMobileNumber();
            string password=validatePassword();
            UserDetails userDetails = new UserDetails(firstName, lastName, email, mobileNumber, password);
            userDetailsList.Add(userDetails);
            Console.Clear();
            Console.WriteLine("User Details:");
            foreach(var v in userDetailsList)
            {
                Console.WriteLine("First Name: "+v.firstName+"\nLast Name: "+v.lastName+"\nEmail: "+v.email+"\nMobile Number: "+v.mobileNumber+"\nPassword: "+v.password);
            }
            

        }
        public void checkEmailSamples()
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

    }
}
