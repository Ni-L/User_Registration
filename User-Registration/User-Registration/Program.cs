using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entery point For Check Password Valid or not
            //WelCome message
            Console.WriteLine("*********Welcome To User Registration**********");
            //Regular Expresion pattern for password minimum 8 char.
            string pattern = "^[A-Za-z0-9]{8,}$";
            // Creating object
            Program p = new Program(); 
            p.ValidPass(pattern);
            Console.WriteLine();
            Console.Read();
        }
        //Creating Method to validate string
        public void ValidPass(string pattern) 
        {
            //Write
            Console.WriteLine("Validation Of The Password");
            //Creating Object of Regex 
            Regex regex = new Regex(pattern);
            //Calling Method for itereting 
            IterateLoop(regex); 
        }
        //Creating Method For Iterating 
        public void IterateLoop(Regex regex)
        {
            //initialize i value
            int i = 0; 
            //Starting the While Loop 
            while (i != 1)
            {
                Console.WriteLine("Enter Password");
                string Password = Console.ReadLine();
                //call the IsMatch metod to determine whether a match is present
                bool result = regex.IsMatch(Password);
                //check result is true or not using if and hence using bool
                //Starting of If Loop
                if (result == true)  
                {
                    //If the Password is true then print 
                    Console.WriteLine("Valid password");
                    i = 1;
                }
                else
                {
                    //If False then Print
                    Console.WriteLine("Enter minimum eight character");
                }
                //End of If Loop
            }
            //End of While Loop
        }

    }
}