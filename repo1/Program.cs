// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите год:");
        int year = int.Parse(Console.ReadLine());

        if (year % 4 == 0)
        {
            Console.WriteLine("{0} - високосный год", year);
        }
        else
        {
            Console.WriteLine("{0} - не високосный год", year);
        }
    }
}
