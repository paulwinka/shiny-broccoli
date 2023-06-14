using System;

namespace _20230614_control_flows
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var rand = new Random();
            for (var i = 0; i < 25; i++)
            {
                Console.Write((char)rand.Next(97, 122));
            }
            var password = new string()
        }
    }
}