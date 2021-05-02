using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{/// <summary>
/// Create Class For Pattern
/// </summary>
    public class UserDetailsPattern
    {
        public const string FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";// pattren for firstname
        public const string LastName = "^[A-Z]{1}[A-Za-z]{2,}$";//pattren for lastname
        public const string Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";//// pattren for  Email
        public const string PhoneNumber = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";// pattren for  number 
        public const string Password = "^(?=.*[A-Z])(?=.*\\d)[\\S]{8,}$";// pattren for  password

        //Using Lambda Expressions for Calling
        public bool ValidateFirstName(string firstName)
        {
            return UserDetailsPattern.Equals(FirstName, FirstName);
        }
        public bool ValidateLastName(string lastName)
        {
            return UserDetailsPattern.Equals(LastName, lastName);
        }
        public bool ValidateEmail(string email)
        {
            return UserDetailsPattern.Equals(Email, email);
        }
        public bool ValidateMobile(string phoneNumber)
        {
            return UserDetailsPattern.Equals(PhoneNumber, phoneNumber);
        }
        public bool ValidatePassword(string password)
        {
            return UserDetailsPattern.Equals(Password, password);
        }
    }
}
