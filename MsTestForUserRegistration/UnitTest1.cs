using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Registration;
namespace MsTestForUserRegistration
{

    [TestClass]
    public class Test
    {
        [TestMethod]

        public void GivenUserFistName_WhenValidate_ShouldReturnresult()
        {
            RegexPattern pattern = new RegexPattern();//Create Object
            bool expected = true;
            //Act
            bool output = pattern.ValidateFirstName("Nilima");
            //Assert
            Assert.AreEqual(expected, output);
        }
    }
    }
