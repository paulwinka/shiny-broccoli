using System;
using System.Collections.Generic;
using System.Text;

namespace _20230612_conditionals_exercise
{
    public class NumberChecker
    {
        public static bool CheckIfInteger(string response)
        {
            bool parseSuccessful;
            int result;
            return parseSuccessful = int.TryParse(response, out result);
        }

        public static string CheckIfInRange(int rangeNumber)
        {
            if (rangeNumber < 11 && rangeNumber > 0)
            {
                return "In range";
            }
            else
            {
                return "Not in range";
            }
        }

        public static int ConvertToInt(string userInput)
        {
            int resultInteger = Int32.Parse(userInput);
            return resultInteger;
        }
    }
}