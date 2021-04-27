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
        [DataRow("Nilima")]
        [DataRow("Snehal")]
        [DataRow("Bajaj")]
        [DataRow("Ashu")]
        [DataRow("Raju")]
        [DataRow("ashwini")]
        [DataRow("Priya")]
        [DataRow("Akhilesh")]
        [DataRow("Nita")]
        [DataRow("Shivam")]
        [DataRow("aadesh")]
        public void Given_FirstName_StartsWithCapital_MinThreeCharacter_ShouldReturnTrue(string name)
        {
            try
            {
                string result = userDetailsPattern.ValidateFirstName(name);
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
        [DataRow("Niliam")]
        [DataRow("shivam")]
        [DataRow("Ashu")]
        [DataRow("Snehal")]
        [DataRow("Nita")]
        [DataRow("aadesh")]
        [DataRow("ashwini")]
        public void GivenFirstName_IfNotStartsWithCapital_ButMinThreeCharacter_ShouldReturnFalse(string invalidFirstName)
        {
            try
            {
                string result = userDetailsPattern.ValidateFirstName(invalidFirstName);
            }
            catch (HandleException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }
        }

    }
}
