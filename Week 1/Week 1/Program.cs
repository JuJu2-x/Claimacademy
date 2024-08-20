using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            Console.ReadKey(); //Wait for key press to close the pressed 

            // Wait for the user to enter the number, and then save the number for firstNumberInput variable
            // The inout should be an integer (whole number), otherwise the program will crash.
            // Later on we will learn about execptions handiling to work around this problem.
            firstNumberInput = Console.ReadLine();

            // Once the number is entered, we will convert the string represantaion of the number to an integer
            // Once it is converted to an integer , we can then do math operations on the number.
            // This number will be saved to the int we declared above called "x"
            x = Convert.ToInt32(firstNumberInput);

            // We will then repeat this process with the second number
            int y; //Declare int for second number
            Console.Write("Please enter the second number:");
            string secondNumberInput;

            // We will then declare a third int called "sum: to store the sum (x + y)
            int sum = x + y;

            //Then we will print the sum to the Console
            Console.WriteLine($"The sum of {x} and {y} is {sum}.");
        }

    static void ADD(int x, int y)


        int sum = x + y; 
        Console.WriteLines($"The sum of {x} and {y} is {sum}.")

        static int AddWithReturn(int x, int y) // Method name has to change here as parameters are the same
            
            return x + y; // This return statment will "send back the result. We can then assign a variable with the method called
    }
}
