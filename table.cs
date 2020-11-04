// A C# program that prompts the user to input a positive integer. It should then print the multiplication table of that number.

using System;

namespace myNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplication = 0, i, num;
            Console.Write("Enter the Nth Number : ");
            // Input the number from user
            num = int.Parse(Console.ReadLine());
            for(i = 1; i <= 10; i++)
            {
                multiplication = num * i;
                Console.WriteLine(multiplication);
            }
            
        }
    }
}
