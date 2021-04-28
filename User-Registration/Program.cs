using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entery point 
            UserDetailsPattern pattern = new UserDetailsPattern();
            Console.WriteLine("******Welcome To User Registration******");
            Console.WriteLine("Enter Email ID:");
            string emailID = Console.ReadLine();
            Console.WriteLine(pattern.ValidateEmail(emailID));

        }
    }
}