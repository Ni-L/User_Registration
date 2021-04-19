using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entery point 
            //Write
            Console.WriteLine("-------Welcome To User Registration--------");
            Console.WriteLine();
            //pattern for exactly 1special char. 
            string pattern = "[@#$%^&+=]{1}"; 
            // create object
            Program p = new Program(); 
            p.ValidPass(pattern);
            Console.WriteLine();
            Console.Read();
        }
        //method to validate string
        public void ValidPass(string pattern)
        {
            //Write
            Console.WriteLine("Validation Of The Password");
            //Creating Object of Regex
            Regex regex = new Regex(pattern);
            //calling method
            IterateLoop(regex);  
        }
        //Method for Iterate 
        public void IterateLoop(Regex regex)
        {
            //initialize i value
            int i = 0;
            //Staring of While Loop
            while (i != 1)
            {
                //Write And Read
                Console.WriteLine("Enter Password");
                string Password = Console.ReadLine();
                //call the IsMatch metod to determine whether a match is present
                bool result = regex.IsMatch(Password);  
                //check result is true or not using if and hence using bool
                if (result == true)  
                {
                    //If True Print
                    Console.WriteLine("Valid password");
                    i = 1;
                }
                else
                {
                    //If false Print
                    Console.WriteLine("Enter atlest one special character");
                }
                //End of If Loop
            }
            //End of While Loop
        }

    }
}