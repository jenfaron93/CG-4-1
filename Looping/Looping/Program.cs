using System;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
			double number = 0; //intializing a user entered variable
			double sum = 0; //intializing a sum variable

			Console.WriteLine("Please enter a number: ");

			while (!double.TryParse(Console.ReadLine(), out number)) { //tests to make sure the number entered by a user is a double
				Console.WriteLine("Please enter a valid number.");
			}

			for(double counter = 2; counter < 21; counter++){ //a loop that starts at 2 and will end at 20
				double result = counter * number; //multiplys the counter by the user's number and stores in result
				Console.WriteLine(result); //writes out the multiplied result
				sum = sum + result; //adds the result to sum
			}

			Console.WriteLine($"The sum of all previous values is {sum}."); //writes the sum out
			Console.ReadLine();

	   }
    }
}
