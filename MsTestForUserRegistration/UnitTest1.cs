using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Registration;
namespace MsTestForUserRegistration
{

    [TestClass]
    public class Test
    {
        private readonly User_Registration userDetailsPattern;
        private readonly object DataRow;

        public Test()
        {
            UserDetailsPattern = new UserDetailsPattern();
        }
        /// <summary>
        /// Test Method to pass invalid email id.
        /// </summary>
        [TestMethod]
        [DataRow("shalu@gmail")]
        [DataRow("shalu@gmail.comm")]
        [DataRow("shalu@gmail.com.ind.us")]
        [DataRow("shalu.#100@gmail")]
        [DataRow("shalu11@gmail.com.a12")]
        [DataRow("shalu@gmail.com.12sa")]
        [DataRow("_shalu@gmail.com")]
        public void GivenEmailId_WhenIsNotProper_ShouldReturnFalse(string emailInvalid)
        {
            try
            {
                string result = userDetailsPattern.ValidateEmail(emailInvalid);
            }
            catch (HandleException e)
            {
                Assert.AreEqual("Invalid email id", e.Message);
            }
        }
    }
}
