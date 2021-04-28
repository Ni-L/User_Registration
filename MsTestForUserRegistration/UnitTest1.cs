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
        /// Pssing all possible invalid password patterns should return invalid password.
        /// </summary>
        [TestMethod]
        [DataRow("Nilima32")]
        [DataRow("nain.558767")]
        [DataRow("Nainau-")]
        [DataRow("dhsfilhd")]
        [DataRow("Nilima#@")]
        [DataRow("Nil#")]
        [DataRow("Naina%5345")]
        [DataRow("Nilima@123")]
        [DataRow("12434@gdhg")]
        [DataRow("Nilima$7")]
        [DataRow("Nilima@#$%123")]
        public void GivenInvalidPassword_ShouldReturnFalse(string invalidPassword)
        {
            try
            {
                string result = userDetailsPattern.ValidatePassword(invalidPassword);
            }
            catch (HandleException e)
            {
                Assert.AreEqual("Invalid password", e.Message);
            }
        }
    }
}
