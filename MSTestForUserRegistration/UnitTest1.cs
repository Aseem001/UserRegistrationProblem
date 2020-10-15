using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;

namespace MSTestForUserRegistration
{
    [TestClass]
    public class UnitTest1
    {    
        /// <summary>
        /// MSTest to check for valid and invalid names
        /// </summary>
        /// <param name="name"></param>
        [TestMethod]
        [DataRow("Virat")]
        [DataRow("kojhli")]
        public void ValidateNameTest(string name)
        {            
            ValidEntry validEntry = new ValidEntry();
            string firstOrLastNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";
            try
            {
                bool actual = validEntry.IsValid(firstOrLastNamePattern, name);
                Assert.AreEqual(true, actual);
            }
            catch(UserRegistrationCustomException e)
            {
                Assert.AreEqual("Exception: Invalid Details Entered", e.Message);
            }
        }

        /// <summary>
        /// MSTest to check for valid and invalid email samples
        /// </summary>
        /// <param name="name"></param>
        [TestMethod]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc.100@abc.com.au")]
        public void ValidateEmailTest(string name)
        {
            ValidEntry validEntry = new ValidEntry();
            string emailPattern = @"^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.][a-zA-Z]{3})+([.][a-zA-Z]{2})?$";
            try
            {
                bool actual = validEntry.IsValid(emailPattern, name);
                Assert.AreEqual(true, actual);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Exception: Invalid Details Entered", e.Message);
            }
        }

        /// <summary>
        /// MSTest to check for valid and invalid mobile numbers
        /// </summary>
        /// <param name="name"></param>
        [TestMethod]
        [DataRow("91 4566784567")]
        [DataRow("47646873 80")]
        public void ValidateMobileNumberTest(string name)
        {
            ValidEntry validEntry = new ValidEntry();
            string mobileNumberPattern = @"^[0-9]{2}[ ][0-9]{10}$";
            try
            {
                bool actual = validEntry.IsValid(mobileNumberPattern, name);
                Assert.AreEqual(true, actual);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Exception: Invalid Details Entered", e.Message);
            }
        }

        /// <summary>
        /// MSTest to check for valid and invalid passwords
        /// </summary>
        /// <param name="name"></param>
        [TestMethod]
        [DataRow("hcAggfG13436@")]
        [DataRow("gchgcL#4675@@")]
        public void ValidatePasswordTest(string name)
        {
            ValidEntry validEntry = new ValidEntry();
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
            try
            {
                bool actual = validEntry.IsValid(passwordPattern, name);
                Assert.AreEqual(true, actual);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Exception: Invalid Details Entered", e.Message);
            }
        }
    }
}
