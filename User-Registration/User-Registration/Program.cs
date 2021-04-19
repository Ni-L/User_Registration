using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entery point of program 
            //Write
            Console.WriteLine("-------Welcome To User Registration--------");
            Console.WriteLine();
            string pattern = "^([A-Za-z\\d-_\\+]+)(\\.[A-Za-z\\d-_]+)?@([a-zA-Z\\d]+)\\.([a-zA-Z]{2,4})(\\.[A-Za-z]{2,4})?$"; //pattern for email sample 
            //Creating Array of Input                                                                                                                  // ASSIGING SOME VALID SAMPLES
            string[] inputs = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com",
                              ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com",
                                "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            // Creating object
            Program p = new Program(); 
            p.ValidPass(inputs, pattern);
            Console.WriteLine();
            Console.Read();
        }
        //method to validate string
        public void ValidPass(string[] arr, string pattern) 
        {
            //Write
            Console.WriteLine("Validation Of The email");
            //Creating method for Regex
            Regex regex = new Regex(pattern);
            //calling method
            IterateLoop(arr, regex); 
        }
        //Method For Iterate 
        public void IterateLoop(string[] arr, Regex regex)
        {
            //check each name string using for loop 
            //Initialized For Loop
            for (int i = 0; i < arr.Length; i++)   

            {
                //Calling the IsMatch metod to determine whether a match is present
                bool result = regex.IsMatch(arr[i]);  
                //checking result is true or not using if and hence using bool
                if (result == true) 
                {
                    //If True Print
                    Console.WriteLine(arr[i] + "---->" + "Valid email");

                }
                else
                {
                    //If False Print
                    Console.WriteLine(arr[i] + "--->" + "Invalid email");
                }
                //End Of If loop
            }
            //End of for Loop
        }



    }
}