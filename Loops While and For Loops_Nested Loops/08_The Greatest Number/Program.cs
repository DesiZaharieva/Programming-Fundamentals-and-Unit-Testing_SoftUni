﻿namespace _08_The_Greatest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int maxNumber = int.MinValue;

            while(command != "Stop")
            {
                int number = int.Parse(command);
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}