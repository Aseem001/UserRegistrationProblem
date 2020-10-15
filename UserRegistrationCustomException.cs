using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationProblem
{
     public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_DETAILS            
        }
        public readonly ExceptionType type;

        /// <summary>
        /// Created Custom Exception For User Reg Problem
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public UserRegistrationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
