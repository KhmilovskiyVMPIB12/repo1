// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the year:");
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("{0} - leap year", year);
        }
        else
        {
            Console.WriteLine("{0} - not a leap year", year);
        }
    }
}
