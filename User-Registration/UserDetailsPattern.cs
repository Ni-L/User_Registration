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
        public static string passwordPattern = "(?=.*[A-Z]{1,})(?=.*[a-z]{1,})(?=.*[0-9]{1,})(?=.*[@#$%+!]{1}).{8,}";
        public Func<string, string> ValidatePassword = x => Regex.IsMatch(x, passwordPattern) ? "Valid password" :
            throw new HandleException(HandleException.ExceptionType.INVALID_PASSWORD, "Invalid password");
    }
}
