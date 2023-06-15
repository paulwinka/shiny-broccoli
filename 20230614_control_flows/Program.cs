using System;

namespace _20230614_control_flows
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int passwordLength = 10;
            var buffer = new char[passwordLength];
            var rand = new Random();
            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + rand.Next(0, 25));
            }
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}