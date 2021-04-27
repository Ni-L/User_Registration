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
        /// Validate first name
        /// </summary>
        [TestMethod]
        [DataRow("Wadal")]
        [DataRow("Snehal")]
        [DataRow("Bajaj")]
        [DataRow("Ashu")]
        [DataRow("Raju")]
        [DataRow("ashwini")]
        [DataRow("Gunde")]
        [DataRow("Akhilesh")]
        [DataRow("Nita")]
        [DataRow("Shivam")]
        [DataRow("aadesh")]
        public void Given_LastName_StartsWithCapital_MinThreeCharacter_ShouldReturnTrue(string name)
        {
            try
            {
                string result = userDetailsPattern.ValidateLastName(name);
            }
            catch (HandleException e)
            {
                Assert.AreEqual("Valid First Name", e.Message);
            }
        }
        /// <summary>
        /// If entered Invalid last name should return false.
        /// </summary>
        [TestMethod]
        [DataRow("Wadal")]
        [DataRow("shivam")]
        [DataRow("Ashu")]
        [DataRow("Snehal")]
        [DataRow("Nita")]
        [DataRow("aadesh")]
        [DataRow("ashwini")]
        public void Given_LastName_IfNotStartsWithCapital_ButMinThreeCharacter_ShouldReturnFalse(string invalidFirstName)
        {
            try
            {
                string result = userDetailsPattern.ValidateLasttName(invalidLAstName);
            }
            catch (HandleException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }
        }

    }
}
