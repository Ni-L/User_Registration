using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{
    public class UserDetailsPattern
    {
        public static string namePattern = "^[A-Z]{1}[A-Za-z]{2,}$";

        public Func<string, string> ValidateLastName = x => Regex.IsMatch(x, namePattern) ? "Valid last Name" :
          throw new HandleException(HandleException.ExceptionType.INVALID_LASTNAME, "Invalid First Name");

       
    }
}
