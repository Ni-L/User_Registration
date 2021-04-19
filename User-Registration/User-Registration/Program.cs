using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entry point for the Mobile Number
            Console.WriteLine("******Welcome To User Registration******");
            string Pattern = "^91\\s[1-9]{1}[0-9]{9}$"; //Pattern to get Number
            //Input Array Numbers
            string[] inputs1 = { "92 8978674532", "91 9146293697", "99922334455", "91 8907562431", "990088776655", "990088awek678543" };

            Program p = new Program(); // Creating object for number 
            p.Validnumber(inputs1, Pattern);
            Console.WriteLine();
            Console.Read();
        }
        //Creating Method for Valid Number And Passes Arguments string type 
        public void Validnumber(string[] arr, string Pattern)   
        {
            Console.WriteLine("Validation Of The Email");
            //Creating Object of Regex 
            Regex regex = new Regex(Pattern);
            //Calling method 
            IterateLoop(arr, regex);  
        }

        //Creating Method for iterateting 
        public void IterateLoop(string[] arr, Regex regex)
        {
            //Starting of for loop for checking upto Array length
            for (int i = 0; i < arr.Length; i++)     

            {
                //Call the IsMatch metod to determine whether a match is present
                bool result = regex.IsMatch(arr[i]);
                //Check result is true or not using if and hence using bool
                if (result == true)  
                {
                    Console.WriteLine(arr[i] + "->" + "Valid");//if true print 

                }
                else
                {
                    Console.WriteLine(arr[i] + "->" + "Invalid MobileNumber");//if false print
                }
                //End of If Else Loop
            }
            //End of for Loop
        }
    }
}