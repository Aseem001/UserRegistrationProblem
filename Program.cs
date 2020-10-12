using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidEntry validEntry = new ValidEntry();
            Console.WriteLine("Welcome to User registration portal!");
            while (true)
            {
                Console.WriteLine("\nEnter\n1-To register and view new user details\n2-To validate given email samples\n3-To exit\n");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.Clear();
                        validEntry.RegisterUserDetails();
                        break;
                    case 2:
                        Console.Clear();
                        validEntry.CheckEmailSamples();
                        break;
                    case 3:
                        break;
                }
                if (options == 3)
                    break;
            }
        }
    }
}
