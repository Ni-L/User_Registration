using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entery point 
            //WelCome
            Console.WriteLine("*******Welcome To User Registration******");
            //Regular Expression pattern for atleast 1numeric password 
            string pattern = "[0-9]{1}"; 
            // creating object
            Program p = new Program(); 
            p.ValidPass(pattern);
            Console.WriteLine();
            Console.Read();
        }
        //Method to validate string
        public void ValidPass(string pattern) 
        {
            //Write
            Console.WriteLine("Validation Of The Password");
            //Creating Object of Regex 
            Regex regex = new Regex(pattern);
            //calling method
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
                //Starting If Loop
                if (result == true)  
                {
                    //If Ture Print
                    Console.WriteLine("Valid password");
                    i = 1;
                }
                else
                {
                    //If False print
                    Console.WriteLine("Enter atlest one numeric number");
                }
                //End of If Loop
            }
            //End of While Loop
        }

    }
}