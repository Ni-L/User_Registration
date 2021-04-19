using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
           
                //Entery point
                ////WelCome message
                Console.WriteLine("*******Welcome To User Registration******");
                //Regular Expression pattern for password minimum 8 char
                string pattern = "^[A-Z]{1}[a-z]{7,}$";
                // Creating object
                Program p = new Program(); 
                p.ValidPass(pattern);
                Console.WriteLine();
                Console.Read();
            }
                //Creating Method to validate string
           public void ValidPass(string pattern) //method to validate string
            {
            //Write
                Console.WriteLine("Validation Of The Password");
            //Creating Object of Regex 
            Regex regex = new Regex(pattern);
            //Calling Method for itereting
            IterateLoop(regex);  //calling method
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
                    //If True Print 
                        Console.WriteLine("Valid password");
                        i = 1;
                    }
                    else
                    {
                    //If False Print
                        Console.WriteLine("Enter minimum eight character and use atlest one Uppercase");
                    }
                //End Of If Loop
            }
            //End of While Loop
        }
    }
}

