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
        /// passing invalid mobile number patterns should return invalid mobile number
        /// </summary>
        [TestMethod]
        [DataRow("91 984875374")]
        [DataRow("91 7766556347")]
        [DataRow("91 8773435")]
        [DataRow("91 9347976655")]
        [DataRow("91 986655")]
        [DataRow("91 98776655")]
        [DataRow("9195899445588776655")]
        [DataRow("91975076655")]
        public void GivenInvalidMobileNumber_ShouldReturnFalse(string invalidMobile)
        {
            try
            {
                string result = userDetailsPattern.ValidateMobileNumber(invalidMobile);
            }
            catch (HandleException e)
            {
                Assert.AreEqual("Invalid mobile number", e.Message);
            }
        }
    }
}
