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
        public static string mailIdPattern = "^[0-9a-zA-Z]+([+_.-][0-9a-zA-Z]+)*@[a-zA-Z0-9]+([.][a-zA-Z]{2,3}){1,2}$";

        public Func<string, string> ValidateEmail = x => Regex.IsMatch(x, mailIdPattern) ? "Valid mailID" :
          throw new HandleException(HandleException.ExceptionType.INVALID_EMAIL_ID, "Invalid email id");

    }
}
