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
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine(pattern.ValidateFirstName(firstName));

          
        }
    }
}