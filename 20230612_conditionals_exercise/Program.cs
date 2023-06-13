using System;

namespace _20230612_conditionals_exercise
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 10.");
            int validInteger;
            var userInput = (Console.ReadLine());
            bool isInteger = (NumberChecker.CheckIfInteger(userInput));
            //Console.WriteLine(isInteger);
            if (isInteger)
            {
                validInteger = NumberChecker.ConvertToInt(userInput);
                //Console.WriteLine(validInteger);
                string result = (NumberChecker.CheckIfInRange(validInteger));
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Not an integer.");
            }
        }
    }
}