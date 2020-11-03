// A C# program to add numbers from 1 to 10.
using System;
namespace naturalNumbers
{
    public class numbers
    {
        public static void Main()
        {
            int sum = 0;
            for(int i = 0; i <= 10; i++)
                sum = sum + i;
            Console.WriteLine(sum);
        }
    }
}
