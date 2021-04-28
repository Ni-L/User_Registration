using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{/// <summary>
/// Create Clss For PAttern
/// </summary>
    public class UserDetailsPattern
    {
        //Pattern for Finding
        public static string mobileNumberPattern = "^[1-9]{2}[ ][0-9]{10}";
        public Func<string, string> ValidateMobileNumber = x => Regex.IsMatch(x, mobileNumberPattern) ? "Valid mobile number" :
             throw new HandleException(HandleException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid mobile number");
    }
}
