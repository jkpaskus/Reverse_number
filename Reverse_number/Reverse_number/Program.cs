using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Created by Jonas Paskus
namespace Reverse_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initiatialize variables to be used in program, by asking user for input.
            //'number' variable is used to remind the user of the number they input, and will be used in the output of the application.
            Console.WriteLine("Enter a number...");
            int numb = int.Parse(Console.ReadLine());
            int number = numb;
            int reverse = 0;

            /*A while loop is used to make sure each digit is removed for the number that was input by the user.  
            As long as there is a digit greater than one remaining in the ones unit placeholder, the program will cycle back to extract all numbers, from last to first. */
            while (numb > 0)
            {
                /*Initialization of rem variable plucks out singles digit and sets it as the first number in the reversed number. 
                This is done by finding the modulus when number is divided by 10, to extract units remaining. */
                int rem = numb % 10;
                //Existing reverse variable multiplied by 10, as long as the remaining number is greater that 0, in order to push the reverse number to the left by one placeholder.
                reverse = (reverse * 10) + rem;
                //Keep updating numb variable to make sure to numbers for the inputted number are dropping down one placeholder at the completion of every loop.
                numb = numb / 10;
            }

            //Formatted string tells user what number they used as input, as well as the reverse of that number.
            Console.WriteLine("Number you input = {0} and reverse number = {1}", number, reverse);
            Console.ReadLine();
        }
    }
}
